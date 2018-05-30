import { Component, OnInit, Input } from '@angular/core';
import { House } from '../../models/house';

@Component({
  selector: 'app-house-thumbnail',
  templateUrl: './house-thumbnail.component.html',
  styleUrls: ['./house-thumbnail.component.css']
})
export class HouseThumbnailComponent implements OnInit {
    @Input() house: House;

  constructor() { }

  ngOnInit() {
  }

}
