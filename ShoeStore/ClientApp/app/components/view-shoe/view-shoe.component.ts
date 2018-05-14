import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastyService } from 'ng2-toasty';
import { ShoeService } from '../../services/shoe.service';

@Component({
  selector: 'app-view-shoe',
  templateUrl: './view-shoe.component.html',
  styleUrls: ['./view-shoe.component.css']
})
export class ViewShoeComponent implements OnInit {

    shoe: any;
    shoeId: number;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private toasty: ToastyService,
        private shoeService: ShoeService) {

        route.params.subscribe(p => {
            this.shoeId = +p['id'];
            if (isNaN(this.shoeId) || this.shoeId <= 0) {
                router.navigate(['/shoes']);
                return;
            }
        });
    }

    ngOnInit() {
        this.shoeService.getShoe(this.shoeId)
            .subscribe(
            s => this.shoe = s,
            err => {
                if (err.status == 404) {
                    this.router.navigate(['/shoes']);
                    return;
                }
            });
    }

    delete() {
        if (confirm("Are you sure?")) {
            this.shoeService.delete(this.shoe.id)
                .subscribe(x => {
                    this.router.navigate(['/shoes']);
                });
        }
    }

}
