import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GatunekComponent } from './gatunek/gatunek.component';
import { KsiazkiComponent } from './ksiazki/ksiazki.component';
import { MenuComponent } from './menu/menu.component';
import { UzytkownikComponent } from './uzytkownik/uzytkownik.component';
import { WypozyczeniaComponent } from './wypozyczenia/wypozyczenia.component';

const routes: Routes = [
  {path:'',component:MenuComponent},
  {path:'ksiazki', component:KsiazkiComponent},
  {path:'wypozyczenia', component:WypozyczeniaComponent},
  { path: 'logowanie', component: UzytkownikComponent},
  { path: 'gatunek', component: GatunekComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
