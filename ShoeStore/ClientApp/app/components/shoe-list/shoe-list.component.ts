import { Component, OnInit } from '@angular/core';
import { Shoe } from "../../models/shoe";
import { ShoeService } from "../../services/shoe.service";
import { KeyValuePair } from"../../models/keyValuePair";
import { Brand } from "../../models/brand";

@Component({
  selector: 'app-shoe-list',
  templateUrl: './shoe-list.component.html',
  styleUrls: ['./shoe-list.component.css']
})
export class ShoeListComponent implements OnInit {
    queryResult: any = {};
    brands: KeyValuePair[];
    query: any = {
        pageSize: 4
    };

    columns = [
        { title: 'Shoe', key: 'shoeName', isSortable: true },
        { title: 'Brand', key: 'brandName', isSortable: true },
        { title: 'View' }
    ];

    constructor(private shoeService: ShoeService) { }

    ngOnInit() {
        this.shoeService.getBrands().subscribe(brands => this.brands =
            brands.map((b: Brand) => ({ id: b.id, name: b.name })));

        this.populateShoes();
    }

    onFilterChange() {
        this.query.page = 1;
        this.populateShoes();
    }

    sortBy(columnName: string) {
        if (this.query.sortBy === columnName)
            this.query.isSortAscending = !this.query.isSortAscending;
        else {
            this.query.sortBy = columnName;
            this.query.isSortAscending = true;
        }

        this.populateShoes();
    }

    onPageChange(page: any) {
        this.query.page = page;
        this.populateShoes();
    }

    private populateShoes() {
        this.shoeService.getShoes(this.query)
            .subscribe(result => this.queryResult = result);
    }

}
