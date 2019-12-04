using KSD.Data;
using KSD.ServiceContracts;
using KSD.UI.Shared;
using KSD.UI.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using Students.Domain.Entities;
using Students.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSD.Services
{

    public class KSDService : IKSDService
    {
        private readonly KSDContext _context;
        private readonly IEmailService _emailService;
        public KSDService(KSDContext context, IEmailService emailService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _emailService = emailService;
        }
        public async Task<List<Student>> GetStudents() => await _context.Students.AsNoTracking().ToListAsync();
        public async Task<Student> GetStudentFullDetails(Guid id) => await _context.Students.Include(p => p.Parents).Include(m => m.Meals).FirstOrDefaultAsync(i => i.Id == id);
        public async Task<Student> GetStudentDetails(Guid id) => await _context.Students.FirstOrDefaultAsync(i => i.Id == id);
        public async Task<Student> GetStudentDetails(string cardNo) => await _context.Students.FirstOrDefaultAsync(i => i.CardNo == cardNo);
        public async Task<List<SMSLog>> GetMSLogs() => await _context.SMSLogs.AsNoTracking().ToListAsync();
        public async Task<Response> AddStudent(StudentDto dto)
        {
            var st = Student.Create(Name.Create(dto.Sur, dto.First, dto.Middle), dto.AdmissionNumber, dto.Grade, dto.CardNo);
            _context.Students.Add(st);
            await _context.SaveChangesAsync();
            return new Response();
        }
        public async Task<Response> AddParent(Guid id, ParentDto dto)
        {
            var st = await GetStudentFullDetails(id);
            if (st != null)
            {
                st.AddParent(Name.Create(dto.Sur, dto.First, dto.Middle), dto.Phone, dto.Phone2, dto.PhysicalLocation, dto.Email);
                _context.Students.Update(st);
                await _context.SaveChangesAsync();
                return new Response();
            }
            return new Response(new List<string> { "Student not found" });
        }
        public async Task<Response> AddMeal(Guid id, MealDto dto)
        {
            var st = await GetStudentFullDetails(id);
            if (st != null)
            {
                if(st.Parents.Count > 0)
                {
                    var p = st.Parents.First();
                    st.AddMeal(dto.MealType, dto.POSId);
                    _context.Students.Update(st);
                    //SMS
                    var s = SMSLog.Create(p.Phone, $"Dear {p.Name.First} student has ordered a meal on {DateTime.UtcNow} ...");
                     _context.SMSLogs.Add(s);
                    await _context.SaveChangesAsync();
                    //Email
                    _emailService.SendMail(p.Email, "Meal Notice", $"Dear {p.Name.First} student has ordered a meal on {DateTime.UtcNow} ...");
                    return new Response();
                }
                return new Response(new List<string> { "Parent not found" });
            }
            return new Response(new List<string> { "Student not found" });
        }
    }
}
