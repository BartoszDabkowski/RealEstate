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
    [Route("api/houses")]    
    public class HouseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public HouseController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork ?? 
                throw new System.ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper ??
                throw new System.ArgumentNullException(nameof(mapper));
        }
        //[HttpGet]
        //public async Task<IEnumerable<HouseResource>> GetHouseAsync()
        //{
        //    var houses = await _unitOfWork.Houses.GetHousesAsync();

        //    return _mapper.Map<IEnumerable<House>, IEnumerable<HouseResource>>(houses);
        //}

        [HttpGet("types")]
        public async Task<IEnumerable<KeyValuePairResource>> GetHouseTypesAsync()
        {
            var houseTypes = await _unitOfWork.Houses.GetHouseTypesAsync();

            return _mapper.Map<IEnumerable<HouseType>, IEnumerable<KeyValuePairResource>>(houseTypes);
        }

        [HttpGet]
        public async Task<QueryResultResource<HouseResource>> GetHousesAsync(HouseQueryResource houseQueryResource)
        {
             var filter = _mapper.Map<HouseQueryResource, HouseQuery>(houseQueryResource);

            var queryResult = await _unitOfWork.Houses.GetHousesAsync(filter);

            return _mapper.Map<QueryResult<House>, QueryResultResource<HouseResource>>(queryResult);
        }



    }
}