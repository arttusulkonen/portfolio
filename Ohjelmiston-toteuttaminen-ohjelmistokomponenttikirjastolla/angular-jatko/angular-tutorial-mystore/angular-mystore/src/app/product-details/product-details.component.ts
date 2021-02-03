import { Component, OnInit } from '@angular/core';
import { products } from '../products';
import { ActivatedRoute } from '@angular/router';
import { CartService } from '../cart.service';


@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {

  products = products;
  product;

  constructor(private route: ActivatedRoute, private cartService: CartService) { }

  ngOnInit() {
    console.log(this.products);
    this.route.paramMap.subscribe(params => {
      this.product = products[+params.get('productId')];
    });

  }
  addToCart(product) {
    window.alert('Your product has been added to the cart!');
    this.cartService.addToCart(product);
  }

}
