import {Component, Input} from '@angular/core';

@Component({
  selector: 'app-display-details',
  templateUrl: './display-details.component.html',
  styleUrls: ['./display-details.component.css']
})
export class DisplayDetailsComponent  {
  isShow = false;
  loki: string[] = [];

  toggleDisplay(): void{
    this.isShow = !this.isShow;
    this.loki.push(new Date().toLocaleString());
  }
}


