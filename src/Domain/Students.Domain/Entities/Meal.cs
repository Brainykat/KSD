using Students.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Domain.Entities
{
    public class Meal
    {
        internal static Meal Create(Guid studentId, MealType mealType, long pOSId) =>
            new Meal(studentId, mealType, pOSId);
        private Meal(Guid studentId, MealType mealType, long pOSId)
        {
            StudentId = studentId;
            MealType = mealType;
            POSId = pOSId;
            OrderTime = DateTime.UtcNow;
        }
        private Meal() { }
        public int Id { get; set; }
        public Guid StudentId { get; set; }
        public MealType  MealType { get; set; }
        public long POSId { get; set; }
        public bool IsServed { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime? ServiceTime { get; set; }
    }
}
