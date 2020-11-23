import { Component, OnInit } from '@angular/core';
import {faRadiation} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-warning-alert',
  templateUrl: './warning-alert.component.html',
  styleUrls: ['./warning-alert.component.css']
})
export class WarningAlertComponent implements OnInit {
  radiation = faRadiation;
  constructor() { }

  ngOnInit(): void {
  }

}
