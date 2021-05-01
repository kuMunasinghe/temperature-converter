import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TemperatureCoverterComponent } from './temperature-coverter/temperature-coverter.component';


const routes: Routes = [{ path: 'temperature-converter', component: TemperatureCoverterComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
