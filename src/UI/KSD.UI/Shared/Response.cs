using System;
using System.Collections.Generic;
using System.Text;

namespace KSD.UI.Shared
{
    public class Response
    {
        public Response() { }
        public Response(List<string> messages)
        {
            Status = false;
            Messages = messages;
        }
        public bool Status { get; set; } = true;
        public List<string> Messages { get; set; }
    }
}
