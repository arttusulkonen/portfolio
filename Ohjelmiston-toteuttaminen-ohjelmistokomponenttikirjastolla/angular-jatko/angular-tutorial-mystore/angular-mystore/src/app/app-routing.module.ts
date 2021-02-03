import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductListComponent } from './product-list/product-list.component';
import { CartComponent} from './cart/cart.component';
import { HttpClientModule } from '@angular/common/http';
import {ProductDetailsComponent} from './product-details/product-details.component';


const routes: Routes = [
  {path: '', component: ProductListComponent},
  {path: 'cart', component: CartComponent},
  {path: 'products/:productId', component: ProductDetailsComponent}

];

@NgModule({
  imports: [HttpClientModule, RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
