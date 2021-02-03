import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import phones from '../../assets/phones/phones.json';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  phones = phones;
  phone;

  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      this.phone = this.phones[+params.get('productId')];
    });
  }

}
