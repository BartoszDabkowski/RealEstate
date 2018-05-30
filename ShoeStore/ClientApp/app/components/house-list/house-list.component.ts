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
    houses: any;
    
    constructor(
        private houseService: HouseService,
        private dataService: DataTransferService) { }

    ngOnInit() {
        this.dataService.currentHousesInList.subscribe(housesInList => this.houses = housesInList);
        this.dataService.applyPaging(1);
    }

    onPageChange(page: any) {
        this.dataService.applyPaging(page);
    }
}
