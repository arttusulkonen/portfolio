import { Component, OnInit } from '@angular/core';
import { products } from '../products';
import { faFacebookF, faTwitterSquare, faInstagram } from '@fortawesome/free-brands-svg-icons';

import { CartService } from '../cart.service';

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
  items;
  product;

  constructor(private cartService: CartService) { }

  addToCart(product) {
    window.alert('Your product has been added to the cart!');
    this.cartService.addToCart(product);
  }

  ngOnInit(): void {
  }

}
