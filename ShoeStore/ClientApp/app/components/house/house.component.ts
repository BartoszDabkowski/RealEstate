import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { HouseService } from '../../services/house.service';

@Component({
  selector: 'app-house',
  templateUrl: './house.component.html',
  styleUrls: ['./house.component.css']
})
export class HouseComponent implements OnInit {
    houseId: any;
    house: any;
    isLoaded = false;

    constructor(private route: ActivatedRoute,
        private router: Router,
        private houseService: HouseService) {

        route.params.subscribe(p => {
            this.houseId = +p['id'];
            if (isNaN(this.houseId) || this.houseId <= 0) {
                router.navigate(['/shoes']);
                return;
            }
        });
    }

    ngOnInit() {
        this.houseService.getHouse(this.houseId)
            .subscribe(
                h => this.house = h,
                err => {
                    if (err.status == 404) {
                        this.router.navigate(['/shoes']);
                        return;
                    }
            },
            () => {
                this.isLoaded = true
            });
    }

}
