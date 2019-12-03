using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.UI.Shared.ViewModels
{
    public class StudentView
    {
        public Guid Id { get; set; }
        public NameView Name { get; set; }
        public string AdmissionNumber { get; set; }
        public string Grade { get; set; }
        public DateTime DateCreated { get; set; }
        public List<ParentView> Parents { get; set; }
        public List<MealView> Meals { get; set; }
    }
}
