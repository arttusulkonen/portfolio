import {Component, Input} from '@angular/core';

@Component({
  selector: 'app-display-details',
  templateUrl: './display-details.component.html',
  styleUrls: ['./display-details.component.css']
})
export class DisplayDetailsComponent  {
  isShow = false;
  loki: string[] = [];
  backgroundColor = false;

  toggleDisplay(): void{
    this.isShow = !this.isShow;
    this.loki.push(new Date().toLocaleString());

    if(this.loki.length > 4){
      this.backgroundColor = true;
    } else {
      this.backgroundColor = false;
    }
  }
}


