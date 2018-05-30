using AutoMapper;
using RealEstate.Controllers.Resources;
using RealEstate.Core.Models;

namespace RealEstate.Mapping
{
    public class MappingProfile : Profile
    {
        private string _photoUrl = "http://localhost:57931/api/photos/";
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap<House, HouseResource>();
            CreateMap<City, CityResource>();
            CreateMap<County, CountyResource>();
            CreateMap<HouseQuery, HouseQueryResource>();
            CreateMap<City, KeyValuePairResource>();
            CreateMap<HouseType, KeyValuePairResource>();
            CreateMap<HouseType, HouseTypeResource>();
            CreateMap<Location, LocationResource>();
            CreateMap(typeof(QueryResult<>), typeof(QueryResultResource<>));
            
            // API to Domain Resource
            CreateMap<HouseResource, House>();
            CreateMap<CityResource, City>();
            CreateMap<CountyResource, County>();
            CreateMap<HouseQueryResource, HouseQuery>();
        }
    }
}