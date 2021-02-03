import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { MainComponent } from './main/main.component';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { MotorolaXoomWifiComponent } from './motorola-xoom-wifi/motorola-xoom-wifi.component';
import { MotorolaXoomComponent } from './motorola-xoom/motorola-xoom.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    MainComponent,
    MotorolaXoomWifiComponent,
    MotorolaXoomComponent
  ],
  imports: [
    BrowserModule,
    FontAwesomeModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: '', component: MainComponent },
      { path: 'products/:productId', component: ProductComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
