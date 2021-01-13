import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AngularDropdownModule } from 'angular-dropdown';
import { DellComponent } from './dell/dell.component';

@NgModule({
  declarations: [
    AppComponent,
    DellComponent,
  ],
    imports: [
        BrowserModule,
        HttpClientModule,
        FormsModule,
        AngularDropdownModule
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
