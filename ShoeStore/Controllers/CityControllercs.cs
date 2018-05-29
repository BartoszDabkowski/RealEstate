using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Controllers.Resources;
using RealEstate.Core;
using RealEstate.Core.Models;

namespace RealEstate.Controllers
{
    [Route("api/cities")]    
    public class CityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CityController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? 
                throw new System.ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ??
                throw new System.ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}/houses")]
        public async Task<IActionResult> GetHousesInCityAsync(int id)
        {
            var houses = await _unitOfWork.Houses.GetHousesInCityAsync(id);

            if (houses == null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<House>, IEnumerable<HouseResource>>(houses));
        }
    }
}