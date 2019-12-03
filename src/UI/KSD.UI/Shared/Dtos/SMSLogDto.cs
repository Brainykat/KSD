using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KSD.UI.Shared.Dtos
{
    public class SMSLogDto
    {
        [Required]
        [MaxLength(15)]
        public string msisdn { get; set; }
        [Required]
        [MaxLength(160)]
        public string Message { get; set; }
        public bool IsSent { get; set; }
    }
}
