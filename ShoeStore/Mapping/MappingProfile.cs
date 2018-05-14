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
            CreateMap<ShoeQueryResource, ShoeQuery>();
            CreateMap<Brand, BrandResource>();
            CreateMap<Style, KeyValuePairResource>();
            CreateMap<Color, KeyValuePairResource>();
            CreateMap<Size, KeyValuePairResource>();
            CreateMap<Photo, PhotoResource>();
            CreateMap<Shoe, ShoeResource>()
                .ForMember(sr => sr.Brand, opt => opt.MapFrom(s => new KeyValuePairResource{ Id = s.Brand.Id, Name = s.Brand.Name}))
                .ForMember(sr => sr.Styles, opt => opt.MapFrom(s => s.ShoeStyles.Select(ss => new KeyValuePairResource{ Id = ss.Style.Id, Name = ss.Style.Name})))
                .ForMember(sr => sr.Colors, opt => 
                    opt.MapFrom(s => s.Inventory
                        .GroupBy(i => i.Color.Id, (x, y) => new { Key = x, Value = y.FirstOrDefault() })
                        .Select(i => new KeyValuePairResource{ Id = i.Value.Color.Id, Name = i.Value.Color.Name})))
                .ForMember(sr => sr.Sizes, opt => 
                    opt.MapFrom(s => s.Inventory
                        .GroupBy(i => i.Size.Id, (x, y) => new { Key = x, Value = y.FirstOrDefault() })
                        .Select(i => new KeyValuePairResource{ Id = i.Value.Size.Id, Name = i.Value.Size.Name.ToString()})));

            CreateMap<Shoe, SaveShoeResource>()
                .ForMember(sur => sur.Styles, opt => opt.MapFrom(s => s.ShoeStyles.Select(sur => sur.StyleId)))
                .ForMember(sur => sur.Colors, opt => opt.MapFrom(s => s.Inventory
                    .GroupBy(i => i.ColorId, (x, y) => new { Key = x, Value = y.FirstOrDefault() })
                    .Select(i => i.Value.ColorId)))
                .ForMember(sur => sur.Sizes, opt => opt.MapFrom(s => s.Inventory
                    .GroupBy(i => i.SizeId, (x, y) => new { Key = x, Value = y.FirstOrDefault() })
                    .Select(i => i.Value.SizeId)));

            // API to Domain Resource
            CreateMap<HouseResource, House>();
            CreateMap<CityResource, City>();
            CreateMap<CountyResource, County>();
            CreateMap<HouseQueryResource, HouseQuery>();
            CreateMap<SaveShoeResource, Shoe>()
                .ForMember(s => s.Id, opt => opt.Ignore())
                .ForMember(s => s.Brand, opt => opt.Ignore())
                .ForMember(s => s.ShoeStyles, opt => opt.Ignore())
                .ForMember(s => s.Inventory, opt => opt.Ignore())
                .ForMember(s => s.IsDeleted, opt => opt.Ignore())
                .AfterMap((ssr, s) =>
                {
                    // Remove unselected styles
                    var removedStyles = s.ShoeStyles.Where(st => !ssr.Styles.Contains(st.StyleId)).ToList();
                    foreach (var st in removedStyles)
                        s.ShoeStyles.Remove(st);

                    // Add new styles
                    var addedStyles = ssr.Styles.Where(id => !s.ShoeStyles.Any(st => st.StyleId == id))
                        .Select(id => new ShoeStyle { StyleId = id });
                    foreach (var st in addedStyles)
                        s.ShoeStyles.Add(st);

                    // Soft Delete unselected colors
                    var removedColors = s.Inventory.Where(i => !ssr.Colors.Contains(i.ColorId)).ToList();
                    foreach (var c in removedColors)
                        c.IsDeleted = true;

                    // Re-add soft deleted colors
                    var reAddedColors = s.Inventory.Where(i => ssr.Colors.Contains(i.ColorId) && i.IsDeleted).ToList();
                    foreach (var c in reAddedColors)
                        c.IsDeleted = false;

                    // Add new Colors 
                    var addedColors = ssr.Colors.Where(id => !s.Inventory.Any(i => i.ColorId == id && !i.IsDeleted))
                        .Select(id => new Color { Id = id });
                    foreach (var c in addedColors)
                        foreach(var sizeId in ssr.Sizes)
                            s.Inventory.Add(new Inventory { ShoeId = s.Id, ColorId = c.Id, SizeId = sizeId });
                });
        }
    }
}