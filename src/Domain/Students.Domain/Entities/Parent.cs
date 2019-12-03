using Students.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Domain.Entities
{
    public class Parent
    {
        internal static Parent Create(Guid studentId, Name name, string phone, string phone2, string physicalLocation, string email)
            => new Parent(studentId, name, phone, phone2, physicalLocation, email);
        private Parent(Guid studentId, Name name, string phone, string phone2, string physicalLocation, string email)
        {
            StudentId = studentId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            Phone2 = phone2;
            PhysicalLocation = physicalLocation ?? throw new ArgumentNullException(nameof(physicalLocation));
            Email = email;
        }
        private Parent() { }
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Name Name { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string PhysicalLocation { get; set; }
        
    }
}
