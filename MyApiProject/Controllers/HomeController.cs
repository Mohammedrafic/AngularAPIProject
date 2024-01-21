using DataAccessLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApiProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DbfirstApproachContext _context;
        public HomeController(DbfirstApproachContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return Ok();
        }

        [HttpPost("api/GetLocation/{Id}")]
        public IActionResult GetLocation(int Id)
        {
            return Ok(new {Message = "Success" , Id = Id});
        }

        [HttpGet("api/GetState/{StateName}")]
        public IActionResult GetState(string? StateName)
        {
            if (StateName == null)
                return BadRequest("No Record Found");
            var state = _context.States.Where(x => x.StateName.ToUpper() == StateName.ToUpper()).FirstOrDefault();
            return Ok(state);
        }
    }
}
