import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { KsiazkaComponent } from './ksiazka/ksiazka.component';
import { MenuComponent } from './menu/menu.component';
import { KsiazkiComponent } from './ksiazki/ksiazki.component';
import { WypozyczeniaComponent } from './wypozyczenia/wypozyczenia.component';
import { AutoryzacjaDirective } from './autoryzacja.directive';
import { UzytkownikComponent } from './uzytkownik/uzytkownik.component';

@NgModule({
  declarations: [
    AppComponent,
    KsiazkaComponent,
    MenuComponent,
    KsiazkiComponent,
    WypozyczeniaComponent,
    AutoryzacjaDirective,
    UzytkownikComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
