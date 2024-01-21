using DataAccessLayer.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbRepository.IRepository
{
    public interface ITicketRep
    {
        Task<List<BusRoute>> SearchBus();
    }
}
