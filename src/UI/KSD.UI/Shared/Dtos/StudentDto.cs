using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KSD.UI.Shared.Dtos
{
    public class StudentDto
    {
        [Required]
        [MaxLength(15)]
        public string Sur { get; set; }
        [Required]
        [MaxLength(15)]
        public string First { get; set; }
        
        [MaxLength(15)]
        public string Middle { get; set; }
        [Required]
        [MaxLength(15)]
        public string AdmissionNumber { get; set; }
        [Required]
        [MaxLength(12)]
        public string Grade { get; set; }
        [Required]
        [MaxLength(10)]
        public string CardNo { get; set; }
    }
}
