using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Controllers.Resources;
using RealEstate.Core;
using RealEstate.Core.Models;

namespace RealEstate.Controllers
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

        [HttpGet("types")]
        public async Task<IEnumerable<HouseTypeResource>> GetHouseTypesAsync()
        {
            var houseTypes = await _unitOfWork.Houses.GetHouseTypesAsync();

            return _mapper.Map<IEnumerable<HouseType>, IEnumerable<HouseTypeResource>>(houseTypes);
        }

        [HttpGet("{id}")]
        public async Task<HouseResource> GetHouseAsync(int id)
        {
            var house = await _unitOfWork.Houses.GetHouseAsync(id);

            return _mapper.Map<House, HouseResource>(house);
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