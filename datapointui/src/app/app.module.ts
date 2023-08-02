import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SigninComponent } from './modules/authentication/components/signin/signin.component';
import { HttpClientModule } from '@angular/common/http';
import { AccessdataComponent } from './modules/accessdata/components/accessdata/accessdata.component';

@NgModule({
  declarations: [
    AppComponent,
    SigninComponent,
    AccessdataComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
