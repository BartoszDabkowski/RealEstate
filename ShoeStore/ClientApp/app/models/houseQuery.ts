export class HouseQuery{
    cityId: number;
    houseTypeId: number;
    minBathrooms: number;
    minBedrooms: number;
    minPrice: number;
    maxPrice: number;
    minSqFt: number;
    maxSqFt: number;
    hasView: boolean;
    hasWaterfront: boolean;

    sortBy: string;
    isSortAscending: boolean;
    page: number;
    pageSize: number;

}