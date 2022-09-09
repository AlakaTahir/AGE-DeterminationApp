using Ageapp.Service;
using AgeApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
     private readonly IStatusService _statusService;

        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }
        [HttpPost]
        public IActionResult ShowStatus(CollectorModel model) 
        {
            string result = _statusService.ShowStatus(model);
            return Ok (result);
        }
    }
}
