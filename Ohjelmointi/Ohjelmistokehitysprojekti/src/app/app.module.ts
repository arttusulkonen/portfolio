import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { PaasivuComponent } from './paasivu/paasivu.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    PaasivuComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
