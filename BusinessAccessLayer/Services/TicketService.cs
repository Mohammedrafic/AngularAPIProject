using BusinessAccessLayer.Models;
using BusinessAccessLayer.Services.IServices;
using DataAccessLayer.DbRepository.IRepository;
using DataAccessLayer.Models.DB;
using DataAccessLayer.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services
{
    public class TicketService : ITicketService
    {
        private readonly IGenericRepository<Location> _repository;
        private readonly ITicketRep _rep;
        public TicketService(IGenericRepository<Location> repository, ITicketRep rep)
        {
            _repository = repository;
            _rep = rep;   
        }
        public async Task<List<Location>> SearchBus(Ticket ticket)
        {
            return null;
        }

        public async Task<List<Location>> GetBySearchFilter(string Value)
        {
            var Location = await _repository.GetAll();
            var result = Location.Where(x => x.Lname.ToUpper().Contains(Value.ToUpper())).ToList();
            return result;
        }
    }
}
