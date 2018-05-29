
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { HouseService } from "./house.service";
import { CountyService } from "./county.service";
import { House }  from "../models/house";
import { Location } from "../models/location";

@Injectable()
export class DataTransferService {

    private houses = new BehaviorSubject<House[]>(Array<House>());
    currentHouses = this.houses.asObservable();

    private location = new BehaviorSubject<Location>({
        latitude: 47.805838,
        longitude: -122.257385
    });
    currentLocation = this.location.asObservable();

    constructor(
        private houseService: HouseService,
        private countyService: CountyService) { }

    applyFiltering(filter: any) {
        this.houseService.getHouses(filter).subscribe(houses => this.houses.next(houses.items));
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
