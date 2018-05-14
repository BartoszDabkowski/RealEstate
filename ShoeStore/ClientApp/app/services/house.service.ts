import { Http } from '@angular/http';
import { Injectable } from '@angular/core';
import 'rxjs/add/operator/map';

@Injectable()
export class HouseService {
    houseEndpoint: string = 'api/houses/'
;  constructor(private http: Http) { }
  
    getHouses(queryObj: any){
        return this.http.get(this.houseEndpoint + '?' + this.toQueryString(queryObj))
        .map(res => res.json());
    }

    getHouse(id: number) {
        return this.http.get(this.houseEndpoint + id)
            .map(res => res.json());
    }

    toQueryString(queryObj: any) {
        var parts = [];
        for (var property in queryObj) {
            var value = queryObj[property];
            if (value != null && value != undefined)
                parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
        }
        return parts.join('&');
    }

    getHouseTypes() {
        return this.http.get(this.houseEndpoint + 'types')
            .map(res => res.json());
    }

    getHousesInCity(cityId: number) {
        return this.http.get('api/cities/' + cityId + '/houses')
            .map(res => res.json());
    }

    getHousesInCounty(countyId: number) {
        return this.http.get('api/counties/' + countyId + '/houses')
            .map(res => res.json());
    }
}
