import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import sampleData from '../../assets/phones/phones.json';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {

  phones: any = sampleData;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {

  }

}
