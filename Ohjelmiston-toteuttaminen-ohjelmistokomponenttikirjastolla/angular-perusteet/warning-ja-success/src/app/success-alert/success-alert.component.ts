import { Component, OnInit } from '@angular/core';
import {faThumbsUp} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-success-alert',
  templateUrl: './success-alert.component.html',
  styleUrls: ['./success-alert.component.css']
})
export class SuccessAlertComponent implements OnInit {
  faCoffee = faThumbsUp;
  constructor() { }

  ngOnInit(): void {
  }

}
