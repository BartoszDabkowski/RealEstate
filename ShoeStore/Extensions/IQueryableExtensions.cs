using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RealEstate.Core.Models;

namespace RealEstate.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<House> ApplyFiltering(this IQueryable<House> query, HouseQuery queryObj)
        {
            if (queryObj.CountyId.HasValue)
                query = query.Where(h => h.Address.City.CountyId.Equals(queryObj.CountyId));

            if (queryObj.CityId.HasValue)
                query = query.Where(h => h.Address.CityId.Equals(queryObj.CityId));

            if (queryObj.HouseTypeId.HasValue)
                query = query.Where(h => h.HouseTypeId.Equals(queryObj.HouseTypeId));

            if (queryObj.HasView.HasValue)
                query = query.Where(h => h.HasView.Equals(queryObj.HasView));

            if (queryObj.HasWaterfront.HasValue)
                query = query.Where(h => h.HasWaterfront.Equals(queryObj.HasWaterfront));

            if (queryObj.MinBathrooms.HasValue)
                query = query.Where(h => h.Bathrooms >= queryObj.MinBathrooms);

            if (queryObj.MinBedrooms.HasValue)
                query = query.Where(h => h.Bedrooms >= queryObj.MinBedrooms);

            if (queryObj.MinPrice.HasValue && queryObj.MaxPrice.HasValue)
                query = query.Where(h => h.Price >= queryObj.MinPrice && h.Price < queryObj.MaxPrice);

            if (queryObj.MinSqFt.HasValue && queryObj.MaxSqFt.HasValue)
                query = query.Where(h => h.SquareFootage >= queryObj.MinSqFt && h.Price < queryObj.MaxSqFt);

            return query;
        }
        public static IQueryable<T> ApplyOrdering<T>(this IQueryable<T> query, IQueryObject queryObj, Dictionary<string, Expression<Func<T, object>>> columnsMap)
        {
            if(String.IsNullOrWhiteSpace(queryObj.SortBy) || !columnsMap.ContainsKey(queryObj.SortBy))
                return query;

            return queryObj.IsSortAscending ? query.OrderBy(columnsMap[queryObj.SortBy]) : query.OrderByDescending(columnsMap[queryObj.SortBy]);
        }

        public static IQueryable<T> ApplyPaging<T>(this IQueryable<T> query, IQueryObject queryObj)
        {
            if (queryObj.Page <= 0)
                queryObj.Page = 1;

             if (queryObj.PageSize <= 0)
                queryObj.PageSize = 30;

            return query.Skip((queryObj.Page - 1) * queryObj.PageSize).Take(queryObj.PageSize);
        }
    }
}
