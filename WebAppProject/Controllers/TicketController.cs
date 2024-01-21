using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using WebAppProject.Models;
using WebAppProject.Static_val;

namespace WebAppProject.Controllers
{
    public class TicketController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public TicketController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory;
        }
        public IActionResult Ticket()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Ticket(Ticket ticket)
        {
            if (ticket.From == null && ticket.To == null && ticket.Date == null) return View();
            var httpclient = _httpClient.CreateClient();
            var response = await httpclient.PostAsJsonAsync($"{HttpReq.URL}/Ticket/api/Ticket", ticket);
            if (response.IsSuccessStatusCode)
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                var Ticket = JsonConvert.DeserializeObject<List<Ticket>>(apiResponse);
                return View();
            }
            else
            {
                return StatusCode((int)response.StatusCode, "API request failed");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations(string Value)
        {
            try
            {
                if (string.IsNullOrEmpty(Value)) return Json(null);
                var httpclient = _httpClient.CreateClient();
                var response = await httpclient.GetAsync($"{HttpReq.URL}/Ticket/api/GetLocations/{Value}");
                if (response.IsSuccessStatusCode)
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    var Locations = JsonConvert.DeserializeObject<List<Locations>>(apiResponse);
                    return Json(Locations);
                }
                else
                {
                    return Json(null);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
