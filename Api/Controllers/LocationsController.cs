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
    public class LocationsController : ControllerBase
    {
        private readonly ILocationsRepository _locationsRepository;
        
        public LocationsController(ILocationsRepository locationsRepository)
        {
            _locationsRepository = locationsRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> Get()
        {
            return Ok(await _locationsRepository.GetLocations());
        }
        
        [HttpGet("{locationId}")]
        public async Task<ActionResult<IEnumerable<Location>>> Get(int locationId)
        {
            Location? location = await _locationsRepository.GetLocation(locationId);

            if (location != null)
            {
                return Ok(location);
            }

            return NotFound();
        }
        
        [HttpPost]
        public async Task<ActionResult> Post(Location location)
        {
            try
            {
                await _locationsRepository.AddLocation(location);
                return Ok(location);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}