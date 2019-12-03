using Students.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KSD.UI.Shared.Dtos
{
    public class MealDto
    {
        [Required]
        public MealType MealType { get; set; }
        [Required]
        public long POSId { get; set; }
    }
}
