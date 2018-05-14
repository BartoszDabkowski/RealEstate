import { Component, OnInit } from '@angular/core';
import { HouseService } from '../../services/house.service';
import { CountyService } from '../../services/county.service';
import { DataTransferService } from "../../services/data-transfer.service";

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
    filter: any = {};
    isCollapsed = false;

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
        var selectedCounty = this.counties.find(c => c.id == this.filter.countyId);
        this.cities = selectedCounty.cities.filter(this.checkCities);

        this.dataService.changeId(this.filter.countyId);
    }

    onCityChange() {
        var selectedCity = this.cities.find(c => c.id == this.filter.cityId);
        this.houseService.getHousesInCity(selectedCity.id).subscribe(houses =>
            this.houses = houses);
    }

    private checkCounties(county: any) {
        var validCounties = [53061, 53033];
        return validCounties.indexOf(county.id) > -1;
    }

    private checkCities(city: any) {
        var validCounties = [27];
        return validCounties.indexOf(city.id) > -1;
    }

}
