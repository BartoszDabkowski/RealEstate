import { Component, OnInit } from '@angular/core';
import { House } from "../../models/house";
import { HouseService } from "../../services/house.service";
import { DataTransferService } from "../../services/data-transfer.service";

@Component({
  selector: 'app-google-map',
  templateUrl: './google-map.component.html',
  styleUrls: ['./google-map.component.css']
})
export class GoogleMapComponent implements OnInit {
    latitude: number = 47.805838;
    longitude: number = -122.257385;
    zoom: number = 10;
    houses: any[];

    constructor(
        private houseService: HouseService,
        private dataService: DataTransferService) { }

    ngOnInit() {
        this.dataService.currentHouses.subscribe(houses => this.houses = houses);
        var filter = {};
        this.dataService.applyFiltering(filter);
    }

    onMarkerClick(m: any) {
        console.log(m);
    }

}
