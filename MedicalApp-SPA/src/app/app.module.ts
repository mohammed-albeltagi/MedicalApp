import { MediaclOperationsService } from './_services/mediaclOperations.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { MedicalComponent } from './medical/medical.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@NgModule({
   declarations: [
      AppComponent,
      MedicalComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule
   ],
   providers: [
      MediaclOperationsService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
