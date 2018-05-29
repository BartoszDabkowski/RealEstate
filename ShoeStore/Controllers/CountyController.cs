using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Controllers.Resources;
using RealEstate.Core;
using RealEstate.Core.Models;

namespace RealEstate.Controllers
{
    [Route("api")]    
    public class CountyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CountyController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? 
                throw new System.ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ??
                throw new System.ArgumentNullException(nameof(mapper));
        }

        [HttpGet("counties")]
        public async Task<IActionResult> GetCountiesAsync()
        {
            var counties = await _unitOfWork.Counties.GetCountiesAsync();

            if (counties == null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<County>, IEnumerable<CountyResource>>(counties));
        }

        [HttpGet("counties/{id}/cities")]
        public async Task<IActionResult> GetCitiesAsync(int id)
        {
            var cities = await _unitOfWork.Counties.GetCitiesinCountyAsync(id);

            if (cities == null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<City>, IEnumerable<CityResource>>(cities));
        }

        [HttpGet("counties/{id}/houses")]
        public async Task<IActionResult> GetCountiesAsync(int id)
        {
            var houses = await _unitOfWork.Counties.GetHousesinCountyAsync(id);

            if (houses == null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<House>, IEnumerable<HouseResource>>(houses));
        }

        [HttpGet("counties/{id}/location")]
        public async Task<IActionResult> GetCountyLocationAsync(int id)
        {
            var location = await _unitOfWork.Counties.GetCountyLocationAsync(id);

            if (location == null)
                return NotFound();

            return Ok(_mapper.Map<Location, LocationResource>(location));
        }

        [HttpGet("cities/{id}/location")]
        public async Task<IActionResult> GetCityLocationAsync(int id)
        {
            var location = await _unitOfWork.Counties.GetCityLocationAsync(id);

            if (location == null)
                return NotFound();

            return Ok(_mapper.Map<Location, LocationResource>(location));
        }
    }
}