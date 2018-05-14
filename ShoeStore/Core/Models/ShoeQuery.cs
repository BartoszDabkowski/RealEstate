using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ShoeStore.Extensions;

namespace ShoeStore.Core.Models
{
    public class ShoeQuery : IQueryObject
    {
        public int? BrandId { get; set; }
        public int? ShoeId { get; set; }

        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
