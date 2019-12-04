using KSD.UI.Shared;
using KSD.UI.Shared.Dtos;
using Students.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KSD.ServiceContracts
{
    public interface IKSDService
    {
        Task<Response> AddMeal(Guid id, MealDto dto);
        Task<Response> AddParent(Guid id, ParentDto dto);
        Task<Response> AddStudent(StudentDto dto);
        Task<Student> GetStudentDetails(Guid id);
        Task<Student> GetStudentDetails(string cardNo);
        Task<Student> GetStudentFullDetails(Guid id);
        Task<List<Student>> GetStudents();
        Task<List<SMSLog>> GetMSLogs();
    }
}
