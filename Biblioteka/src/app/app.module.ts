import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UzytkownikComponent } from './uzytkownik/uzytkownik.component';
import { KsiazkaComponent } from './ksiazka/ksiazka.component';
import { MenuComponent } from './menu/menu.component';
import { KsiazkiComponent } from './ksiazki/ksiazki.component';
import { WypozyczeniaComponent } from './wypozyczenia/wypozyczenia.component';
import { AutoryzacjaDirective } from './autoryzacja.directive';
import { GatunekComponent } from './gatunek/gatunek.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    UzytkownikComponent,
    KsiazkaComponent,
    MenuComponent,
    KsiazkiComponent,
    WypozyczeniaComponent,
    AutoryzacjaDirective,
    GatunekComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MatSliderModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
