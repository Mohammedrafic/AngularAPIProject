using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Models
{
    public class Ticket
    {
        public string? From { get; set; }
        public string? To { get; set; }
        public DateTime? Date { get; set; }
    }
}
