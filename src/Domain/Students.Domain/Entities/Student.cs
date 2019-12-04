using Students.Domain.Enums;
using Students.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Domain.Entities
{
    public class Student
    {
        public static Student Create(Name name, string admissionNumber, string grade, string cardNo) =>
            new Student(name, admissionNumber, grade, cardNo);
        public void AddParent(Name name, string phone, string phone2, string physicalLocation, string email) =>
            Parents.Add(Parent.Create(this.Id, name, phone, phone2, physicalLocation,email));
        public void AddMeal(MealType mealType, long pOSId) =>
            Meals.Add(Meal.Create(this.Id, mealType, pOSId));
        private Student(Name name, string admissionNumber, string grade, string cardNo)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            AdmissionNumber = admissionNumber ?? throw new ArgumentNullException(nameof(admissionNumber));
            Grade = grade ?? throw new ArgumentNullException(nameof(grade));
            Parents = new List<Parent>();
            Meals = new List<Meal>();
            DateCreated = DateTime.UtcNow;
            CardNo = cardNo;
        }
        private Student() { }
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public string AdmissionNumber { get; set; }
        public string Grade { get; set; }
        public DateTime DateCreated { get; set; }
        public string CardNo { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Meal> Meals { get; set; }
    }
}
