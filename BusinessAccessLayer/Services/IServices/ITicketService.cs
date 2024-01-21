using BusinessAccessLayer.Models;
using DataAccessLayer.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services.IServices
{
    public interface ITicketService
    {
        Task<List<Location>> SearchBus(Ticket ticket);
        Task<List<Location>> GetBySearchFilter(string Value);
    }
}
