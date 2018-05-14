import { Component, OnInit, Input } from '@angular/core';
import { KeyValuePair } from "../../models/keyValuePair";

@Component({
  selector: 'app-shoe-color-form',
  templateUrl: './shoe-color-form.component.html',
  styleUrls: ['./shoe-color-form.component.css']
})
export class ShoeColorFormComponent implements OnInit {
    @Input() colors: any[];


  constructor() { }

  ngOnInit() {
  }

}
