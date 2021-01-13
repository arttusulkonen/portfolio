import { Component, OnInit } from '@angular/core';
import {HttpClient, HttpErrorResponse} from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{



  title = 'tuoteluettelo';
  name: any;

  constructor(private http: HttpClient){}
  arrPhones: string[];

  ngOnInit(): void {
    this.http.get('../assets/phones.json').subscribe(data => {
      this.arrPhones = data as string[];
    },(err: HttpErrorResponse) => {
      console.log(err.message);
      }
    );
  }
  SortArr($event: any): void {
    this.arrPhones.sort();
  }

  Search(){
    if(this.name === ''){
      this.ngOnInit();
    } else {
      this.arrPhones = this.arrPhones.filter(res => {
        // @ts-ignore
        return res.name.toLocaleLowerCase().match(this.name.toLocaleLowerCase());
      });
    }
  }

}

