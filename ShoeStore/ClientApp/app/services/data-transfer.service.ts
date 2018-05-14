
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { HouseService } from "./house.service";
import { House }  from "../models/house";

@Injectable()
export class DataTransferService {

    private houses = new BehaviorSubject<House[]>(Array<House>());
    currentHouses = this.houses.asObservable();

    constructor(private houseService: HouseService) { }

    applyFiltering(filter: any) {
        this.houseService.getHouses(filter).subscribe(houses => this.houses.next(houses.items));
    }

    changeId(id: number) {
        this.houseService.getHousesInCounty(id).subscribe(houses => this.houses.next(houses));
    }

}
