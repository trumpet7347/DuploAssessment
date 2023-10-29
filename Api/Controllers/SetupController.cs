using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetupController : ControllerBase
    {
        private readonly ILocationsRepository _locationsRepository;
        
        public SetupController(ILocationsRepository locationsRepository)
        {
            _locationsRepository = locationsRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            // LaFollette TN
            Location location1 = await _locationsRepository.AddLocation(36.3845043, -84.1208004);
            // San Jose
            Location location2 = await _locationsRepository.AddLocation(37.3776339, -121.9195819);
            
            return Ok();
        }
    }
}
