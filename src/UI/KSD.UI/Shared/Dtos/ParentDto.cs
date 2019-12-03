using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KSD.UI.Shared.Dtos
{
    public class ParentDto
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
        public string Phone { get; set; }
        
        [MaxLength(15)]
        public string Phone2 { get; set; }
        [Required]
        [MaxLength(150)]
        public string PhysicalLocation { get; set; }
        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }
    }
}
