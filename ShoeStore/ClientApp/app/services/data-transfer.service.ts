
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { HouseService } from "./house.service";
import { CountyService } from "./county.service";
import { House }  from "../models/house";
import { Location } from "../models/location";

@Injectable()
export class DataTransferService {

    private filter: any = {};
    private houses = new BehaviorSubject<House[]>(Array<House>());
    currentHouses = this.houses.asObservable();

    private housesInList = new BehaviorSubject<any>({});
    currentHousesInList = this.housesInList.asObservable();

    private location = new BehaviorSubject<Location>({
        latitude: 47.805838,
        longitude: -122.257385
    });
    currentLocation = this.location.asObservable();

    constructor(
        private houseService: HouseService,
        private countyService: CountyService) { }

    applyFiltering(filter: any) {
        this.filter = filter;
        this.filter.page = 1;
        this.houseService.getHouses(this.filter).subscribe(houses => this.housesInList.next(houses));

        delete filter.pageSize;
        delete filter.page;
        this.houseService.getHouses(filter).subscribe(houses => this.houses.next(houses.items));
    }
    getHouses() {
        this.houseService.getHouses(null).subscribe(houses => this.houses.next(houses.items));
    }

    applyPaging(page: any) {
        this.filter.page = page;
        this.filter.pageSize = 6;
        this.houseService.getHouses(this.filter).subscribe(houses => this.housesInList.next(houses));
    }

    changeId(id: number) {
        this.houseService.getHousesInCounty(id).subscribe(houses => this.houses.next(houses));
    }

    changeLocation(id: number) {
        this.countyService.getLocation(id).subscribe(location => this.location.next(location));
    }

    changeCityLocation(id: number) {
        this.countyService.getCityLocation(id).subscribe(location => this.location.next(location));
    }

}
