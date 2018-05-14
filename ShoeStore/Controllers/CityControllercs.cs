using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Core;
using RealEstate.Core.Models;
using ShoeStore.Controllers.Resources;
using ShoeStore.Core;
using ShoeStore.Core.Models;
using ShoeStore.Persistence;

namespace ShoeStore.Controllers
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