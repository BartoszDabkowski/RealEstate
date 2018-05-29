import { Component, OnInit } from '@angular/core';
import { HouseService } from '../../services/house.service';
import { CountyService } from '../../services/county.service';
import { DataTransferService } from "../../services/data-transfer.service";
import { Location } from "../../models/Location";

@Component({
  selector: 'app-filter-bar',
  templateUrl: './filter-bar.component.html',
  styleUrls: ['./filter-bar.component.css']
})
export class FilterBarComponent implements OnInit {
    houseTypes: any[];
    counties: any[];
    cities: any[];
    houses: any[];
    filter: any = { sortBy: 'price', isSortAscending: true};
    isCollapsed = false;
    location: Location = new Location();

    constructor(
        private houseService: HouseService,
        private countyService: CountyService,
        private dataService: DataTransferService) { }

    ngOnInit() {
        this.houseService.getHouseTypes().subscribe(houseTypes =>
            this.houseTypes = houseTypes);

        this.countyService.getCounties().subscribe(counties =>
            this.counties = counties.filter(this.checkCounties));
    }

    filterHouses() {
        this.dataService.applyFiltering(this.filter);
       this.isCollapsed = true;
    }

    onCountyChange() {
        delete this.filter.cityId;
        this.dataService.changeLocation(this.filter.countyId);

        var selectedCounty = this.counties.find(c => c.id == this.filter.countyId);
        this.cities = selectedCounty.cities.filter(this.checkCities);
    }

    onCityChange() {
        this.dataService.changeCityLocation(this.filter.cityId);
    }

    sortBy(columnName: string) {
        if (this.filter.sortBy === columnName) {
            this.filter.isSortAscending = !this.filter.isSortAscending;
        } else {
            this.filter.sortBy = columnName;
            this.filter.isSortAscending = true;
        }
        this.filterHouses();
    }

    // Filtering cities and counties that have no houses
    private checkCounties(county: any) {
        var validCounties = [53061, 53033];
        return validCounties.indexOf(county.id) > -1;
    }

    private checkCities(city: any) {
        var validCounties = [5, 8, 27];
        return validCounties.indexOf(city.id) > -1;
    }



}
