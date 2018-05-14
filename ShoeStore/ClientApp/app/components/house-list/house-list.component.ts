import { Component, OnInit } from '@angular/core';
import { CountyService } from "../../services/county.service";
import { HouseService } from "../../services/house.service";
import { DataTransferService } from "../../services/data-transfer.service";
import { House } from "../../models/house";

@Component({
  selector: 'app-house-list',
  templateUrl: './house-list.component.html',
  styleUrls: ['./house-list.component.css']
})
export class HouseListComponent implements OnInit {
    counties: any[];
    cities: any[];
    county: any = {};
    city: any = {};
    message: string;
    houses: any[];
    
    constructor(
        private houseService: HouseService,
        private countyService: CountyService,
        private dataService: DataTransferService) { }

    ngOnInit() {
        this.dataService.currentHouses.subscribe(houses => this.houses = houses);
    }
}
