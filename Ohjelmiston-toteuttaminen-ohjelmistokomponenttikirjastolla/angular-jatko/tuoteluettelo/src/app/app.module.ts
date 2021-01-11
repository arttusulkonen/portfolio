import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MotorolaComponent } from './motorola/motorola.component';
import { DellComponent } from './dell/dell.component';
import { LgComponent } from './lg/lg.component';
import { DroidComponent } from './droid/droid.component';
import { SamsungComponent } from './samsung/samsung.component';
import { NexusComponent } from './nexus/nexus.component';
import { TMobileComponent } from './t-mobile/t-mobile.component';
import { SanyoComponent } from './sanyo/sanyo.component';

@NgModule({
  declarations: [
    AppComponent,
    MotorolaComponent,
    DellComponent,
    LgComponent,
    DroidComponent,
    SamsungComponent,
    NexusComponent,
    TMobileComponent,
    SanyoComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
