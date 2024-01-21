using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class Ticket
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime? Date { get; set; }
    }
}