import { Component, OnInit } from '@angular/core';
import { House } from "../../models/house";
import { Location } from "../../models/Location";
import { HouseService } from "../../services/house.service";
import { DataTransferService } from "../../services/data-transfer.service";

@Component({
  selector: 'app-google-map',
  templateUrl: './google-map.component.html',
  styleUrls: ['./google-map.component.css']
})
export class GoogleMapComponent implements OnInit {
    location: Location = {
        latitude: 47.805838,
        longitude: -122.257385
    };
    zoom: number = 10;
    houses: House[];
    blueDot = {
        url: "/images/blue-dot.png",
        scaledSize: {
            width: 20,
            height: 20
        }
    };
    redDot = {
        url: "/images/red-dot.png",
        scaledSize: {
            width: 20,
            height: 20
        }
    };
    greenDot = {
        url: "/images/green-dot.png",
        scaledSize: {
            width: 20,
            height: 20
        }
    };

    constructor(
        private houseService: HouseService,
        private dataService: DataTransferService) { }

    ngOnInit() {
        this.dataService.currentHouses.subscribe(houses => this.houses = houses);
        this.dataService.getHouses();

        this.dataService.currentLocation.subscribe(location => this.location = location);
    }

    onMarkerClick(m: any) {
        console.log(m);
    }

}
