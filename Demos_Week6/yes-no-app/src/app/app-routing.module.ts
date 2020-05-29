import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WelcomeComponent } from './welcome/welcome.component';
import { OracleComponent } from './oracle/oracle.component';

const routes: Routes = [
  { path: 'welcome', component: WelcomeComponent },
  { path: 'oracle', component: OracleComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
