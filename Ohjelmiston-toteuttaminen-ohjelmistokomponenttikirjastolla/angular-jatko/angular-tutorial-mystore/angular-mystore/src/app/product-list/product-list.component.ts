import { Component, OnInit } from '@angular/core';
import { products } from '../products';
import { faFacebookF, faTwitterSquare, faInstagram } from '@fortawesome/free-brands-svg-icons';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  faFacebookF = faFacebookF;
  faTwitterSquare = faTwitterSquare;
  faInstagram = faInstagram;

  products = products;
  constructor() { }

  ngOnInit(): void {
  }

}
