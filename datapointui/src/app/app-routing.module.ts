import { NgModule } from '@angular/core';
import { AccessdataComponent } from './modules/accessdata/components/accessdata/accessdata.component';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';

const routes: Routes = [
    { path: 'signin', component: AppComponent},
    { path: 'accessdata', component: AccessdataComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
