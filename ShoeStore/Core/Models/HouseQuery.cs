using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ShoeStore.Extensions;

namespace ShoeStore.Core.Models
{
    public class HouseQuery : IQueryObject
    {
        public int? CityId { get; set; }
        public int? HouseTypeId { get; set; }
        public int? MinBathrooms { get; set; }
        public int? MinBedrooms { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public int? MinSqFt { get; set; }
        public int? MaxSqFt { get; set; }
        public bool? HasView { get; set; }
        public bool? HasWaterfront { get; set; }

        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
