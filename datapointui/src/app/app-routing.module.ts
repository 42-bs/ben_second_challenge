import { NgModule } from '@angular/core';
import { AccessdataComponent } from './modules/accessdata/components/accessdata/accessdata.component';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { SigninComponent } from './modules/authentication/components/signin/signin.component';

const routes: Routes = [
    { path: '', component: AppComponent},
    { path: 'signin', component: SigninComponent},
    { path: 'accessdata', component: AccessdataComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
