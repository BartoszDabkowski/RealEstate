import { ShoeService } from '../../services/shoe.service';
import { SaveShoe } from '../../models/saveShoe';
import { Shoe } from '../../models/shoe';
import { Component, OnInit } from '@angular/core';
import { ToastyService } from "ng2-toasty";
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/Observable/forkJoin';

@Component({
  selector: 'app-shoe-form',
  templateUrl: './shoe-form.component.html',
  styleUrls: ['./shoe-form.component.css']
})
export class ShoeFormComponent implements OnInit {
    brands: any[];
    styles: any[];
    colors: any[];
    sizes: any[];
    shoe: SaveShoe = {
        id: 0,
        name: "",
        brandId: 0,
        styles: [],
        colors: [],
        sizes: []
    }

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private shoeService: ShoeService,
        private toastyService: ToastyService) {

        route.params.subscribe(p => {
            this.shoe.id = +p['id'];
        });
    }

    ngOnInit() {
        var sources = [
            this.shoeService.getBrands(),
            this.shoeService.getStyles(),
            this.shoeService.getColors(),
            this.shoeService.getSizes()
        ];
        if (this.shoe.id)
            sources.push(this.shoeService.getShoe(this.shoe.id));
        
        Observable.forkJoin(sources).subscribe(data => {
            this.brands = data[0];
            this.styles = data[1];
            this.colors = data[2];
            this.sizes = data[3];

            if (this.shoe.id)
                this.setShoe(data[4]);
            else 
                this.shoe.sizes = this.sizes.map((size: any) => size.id);

        }, err => {
            if (err.status === 404)
                this.router.navigate(['/home']);
        });
    }

    onColorToggle(colorId: number, $event: any) {
        if ($event.target.checked) {
            this.shoe.colors.push(colorId);
        } else {
            var index = this.shoe.colors.indexOf(colorId);
            this.shoe.colors.splice(index, 1);
        }
    }

    onStyleToggle(styleId: number, $event: any) {
        if ($event.target.checked) {
            this.shoe.styles.push(styleId);
        } else {
            var index = this.shoe.styles.indexOf(styleId);
            this.shoe.styles.splice(index, 1);
        }
    }

    submit() {
        if (this.shoe.id)
            this.shoeService.update(this.shoe)
                .subscribe(x => {
                    this.toastyService.success({
                        title: 'Success',
                        msg: 'The shoe was sucessfully updated.',
                        theme: 'bootstrap',
                        showClose: true,
                        timeout: 5000
                    });
                });
        else
            this.shoeService.create(this.shoe).subscribe(x => console.log(x));
    }

    delete() {
        if (confirm("Are you sure?")) {
            this.shoeService.delete(this.shoe.id)
                .subscribe(x => {
                    this.router.navigate(['/home']);
                });
        }
    }

    private setShoe(s: Shoe) {
        this.shoe.id = s.id;
        this.shoe.name = s.name;
        console.log(s.brand);
        this.shoe.brandId = s.brand.id;
        this.shoe.colors = s.colors.map((color: any) => color.id);
        this.shoe.styles = s.styles.map((style: any) => style.id);
        this.shoe.sizes = s.sizes.map((size: any) => size.id);
        console.log(this.shoe);
    }
}
