import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class CountyService {

  constructor(private http: Http) { }
  
    getCounties(){
      return this.http.get('api/counties')
        .map(res => res.json());
    }

    getCitiesInCounty(countyId: number) {
        return this.http.get('api/counties/' + countyId + '/cities')
            .map(res => res.json());
    }

}
