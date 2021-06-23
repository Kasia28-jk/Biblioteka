import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AutoryzacjaGuard } from './autoryzacja.guard';
import { GatunekComponent } from './gatunek/gatunek.component';
import { KsiazkiComponent } from './ksiazki/ksiazki.component';
import { MenuComponent } from './menu/menu.component';
import { UzytkownikComponent } from './uzytkownik/uzytkownik.component';
import { WypozyczeniaComponent } from './wypozyczenia/wypozyczenia.component';

const routes: Routes = [
  {path:'',component:MenuComponent},
  {path:'ksiazki', component:KsiazkiComponent/*, canActivate: [AutoryzacjaGuard]*/},
  {path:'wypozyczenia', component:WypozyczeniaComponent/*, canActivate: [AutoryzacjaGuard]*/},
  {path: 'logowanie', component: UzytkownikComponent},
  {path: 'gatunek', component: GatunekComponent/*, canActivate: [AutoryzacjaGuard]*/}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
