using BusinessAccessLayer.Models;
using BusinessAccessLayer.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiProject.Models;
using Ticket = BusinessAccessLayer.Models.Ticket;

namespace MyApiProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;  
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost("api/Ticket")]
        public async Task<IActionResult> Ticket([FromBody]Ticket ticket)
        {
            var value = await _ticketService.SearchBus(ticket);
            return Ok(value);
        }

        [HttpGet("api/GetLocations/{Value}")]
        public async Task<IActionResult> GetLocations(string Value)
        {
            var value = await _ticketService.GetBySearchFilter(Value);
            return Ok(value);
        }
    }
}
