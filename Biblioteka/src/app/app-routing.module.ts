import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { KsiazkiComponent } from './ksiazki/ksiazki.component';
import { MenuComponent } from './menu/menu.component';
import { WypozyczeniaComponent } from './wypozyczenia/wypozyczenia.component';

const routes: Routes = [
  {path:'',component:MenuComponent},
  {path:'ksiazki', component:KsiazkiComponent},
  {path:'wypozyczenia', component:WypozyczeniaComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
