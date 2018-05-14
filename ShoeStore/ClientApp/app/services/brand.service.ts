import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class BrandService {

  constructor(private http: Http) { }
  
    getBrands(){
      return this.http.get('api/brands')
        .map(res => res.json());
    }

}
