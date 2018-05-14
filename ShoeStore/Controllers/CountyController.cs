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
    [Route("api/counties")]    
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

        [HttpGet]
        public async Task<IActionResult> GetCountiesAsync()
        {
            var counties = await _unitOfWork.Counties.GetCountiesAsync();

            if (counties == null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<County>, IEnumerable<CountyResource>>(counties));
        }

        [HttpGet("{id}/cities")]
        public async Task<IActionResult> GetCitiesAsync(int id)
        {
            var cities = await _unitOfWork.Counties.GetCitiesinCountyAsync(id);

            if (cities == null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<City>, IEnumerable<CityResource>>(cities));
        }

        [HttpGet("{id}/houses")]
        public async Task<IActionResult> GetCountiesAsync(int id)
        {
            var houses = await _unitOfWork.Counties.GetHousesinCountyAsync(id);

            if (houses == null)
                return NotFound();

            return Ok(_mapper.Map<IEnumerable<House>, IEnumerable<HouseResource>>(houses));
        }
    }
}