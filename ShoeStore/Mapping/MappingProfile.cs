using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.NodeServices;
using RealEstate.Core.Models;
using ShoeStore.Controllers.Resources;
using ShoeStore.Core.Models;

namespace ShoeStore.Mapping
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
            CreateMap(typeof(QueryResult<>), typeof(QueryResultResource<>));
            
            // API to Domain Resource
            CreateMap<HouseResource, House>();
            CreateMap<CityResource, City>();
            CreateMap<CountyResource, County>();
            CreateMap<HouseQueryResource, HouseQuery>();
        }
    }
}