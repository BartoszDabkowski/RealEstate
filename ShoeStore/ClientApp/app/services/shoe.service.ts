import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';
import { SaveShoe } from "../models/saveShoe";

@Injectable()
export class ShoeService {
    private readonly shoesEndpoint = 'api/shoes';

  constructor(private http: Http) { }

  getShoes(filter: any){
      return this.http.get(this.shoesEndpoint + '?' + this.toQueryString(filter))
      .map(res => res.json());
  }

  toQueryString(obj: any) {
      var parts = [];
      for (var property in obj) {
          var value = obj[property];
          if (value != null && value != undefined)
              parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
      }
      return parts.join('&');
  }

  getShoe(id: number) {
      return this.http.get(this.shoesEndpoint + '/' + id)
          .map(res => res.json());
  }

  getStyles(){
      return this.http.get(this.shoesEndpoint + '/styles')
      .map(res => res.json());
  }

  getColors(){
      return this.http.get(this.shoesEndpoint + '/colors')
      .map(res => res.json());
  }

  getBrands(){
    return this.http.get('api/brands')
      .map(res => res.json());
  }

  getSizes() {
      return this.http.get(this.shoesEndpoint + '/sizes')
        .map(res => res.json());
  }

  create(shoe: SaveShoe) {
      return this.http.post(this.shoesEndpoint, shoe)
          .map(res => res.json());
  }

  update(shoe: SaveShoe) {
      return this.http.put(this.shoesEndpoint + '/' + shoe.id, shoe)
          .map(res => res.json());
    }

    delete(id: number) {
        return this.http.delete(this.shoesEndpoint + '/' + id)
            .map(res => res.json());
    }
}
