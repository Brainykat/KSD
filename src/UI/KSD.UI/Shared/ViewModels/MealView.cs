using Students.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.UI.Shared.ViewModels
{
    public class MealView
    {
        public int Id { get; set; }
        public Guid StudentId { get; set; }
        public MealType MealType { get; set; }
        public long POSId { get; set; }
        public bool IsServed { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime? ServiceTime { get; set; }
    }
}
