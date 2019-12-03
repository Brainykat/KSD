using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.UI.Shared.ViewModels
{
    public class ParentView
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public NameView Name { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string PhysicalLocation { get; set; }
        public string Email { get; set; }
    }
}
