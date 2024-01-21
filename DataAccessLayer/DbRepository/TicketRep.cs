using DataAccessLayer.Context;
using DataAccessLayer.DbRepository.IRepository;
using DataAccessLayer.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbRepository
{
    public class TicketRep : ITicketRep
    {
        private readonly DbfirstApproachContext _context;
        public TicketRep(DbfirstApproachContext context)
        {
            _context = context;
        }
        public Task<List<Location>> SearchBus()
        {
            return null;
        }

        Task<List<BusRoute>> ITicketRep.SearchBus()
        {
            throw new NotImplementedException();
        }
    }
}
