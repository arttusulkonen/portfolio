import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  items = [];

  constructor( private http: HttpClient) { }

  addToCart(product) {
    this.items.push(product);
  }
}
