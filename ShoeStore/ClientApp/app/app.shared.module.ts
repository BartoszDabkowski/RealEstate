
//import * as Raven from 'raven-js';

import{ AgmCoreModule } from '@agm/core';

import { NgModule, ErrorHandler } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { ToastyModule } from 'ng2-toasty';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppComponent } from './components/app/app.component';
import { HomeComponent } from './components/home/home.component';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { AppErrorHandler } from "./components/app/app.error-handler";
import { PaginationComponent } from './components/pagination/pagination.component';

import { HouseComponent } from './components/house/house.component';
import { HouseListComponent } from './components/house-list/house-list.component';
import { HouseThumbnailComponent } from './components/house-thumbnail/house-thumbnail.component';
import { RangeInputComponent } from './components/range-input/range-input.component';
import { FilterBarComponent } from './components/filter-bar/filter-bar.component';
import { CountyService } from './services/county.service';
import { HouseService } from './services/house.service';
import { DataTransferService } from './services/data-transfer.service';
import { GoogleMapComponent } from './components/google-map/google-map.component';

//Raven.config('https://21356003fef14752a7981418bc98037b@sentry.io/274247').install();

@
NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        NavBarComponent,
        PaginationComponent,
        HouseComponent,
        HouseListComponent,
        HouseThumbnailComponent,
        RangeInputComponent,
        FilterBarComponent,
        GoogleMapComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ToastyModule.forRoot(),
        AgmCoreModule.forRoot({
            apiKey: 'AIzaSyCTEKBgaE6biFDZCv6oxn1oXfjWquuo-HY'
        }),
        NgbModule.forRoot(),
        RouterModule.forRoot([
            { path: '', redirectTo: 'house-list', pathMatch: 'full' },
            { path: 'house-list', component: HouseListComponent },
            { path: 'houses/:id', component: HouseComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [
        { provide: ErrorHandler, useClass: AppErrorHandler },
        CountyService, HouseService, DataTransferService
    ]
})
export class AppModuleShared {
}
