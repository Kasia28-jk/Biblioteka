import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable, of } from 'rxjs';
import {map, tap} from 'rxjs/operators';
import { AutoryzacjaService } from './autoryzacja.service';
import { ksiazka } from './ksiazka.service';

export interface Paginacja{
  strona: number;
  ilosc: number;
}

@Injectable({
  providedIn: 'root'
})
export class WypozyczeniaService {
  private wybraneKsiazki: BehaviorSubject<ksiazka[]>= new BehaviorSubject<ksiazka[]>([]);
  constructor(private http: HttpClient, private autoryzacjaService: AutoryzacjaService) { 
    this.http.get<ksiazka[]>("https://localhost:44383/api/Wypozyczenia",{ headers: this.dolaczNaglowki() }).subscribe(res=>(this.wybraneKsiazki.next(res)));
  }

  pobierzWypozyczenia(): Observable<ksiazka[]>{
    return this.wybraneKsiazki.asObservable();
  }

  wyczyscWypozyczenia(): Observable<void>
  {
  //  this.wybraneAtrykuly.next([]);
  return this.http.put<ksiazka[]>('https://localhost:44383/api/Wypozyczenia',{},{ headers: this.dolaczNaglowki() }).pipe(map(res=>{this.wybraneKsiazki.next(res); return}));
  }

  dodajDoWypozyczenia(id: number): Observable<void>
  {
    return this.http.post<ksiazka[]>('https://localhost:44383/api/Wypozyczenia/'+id,{},{ headers: this.dolaczNaglowki() }).pipe(map(res=>{this.wybraneKsiazki.next(res); return}))
  }

  private dolaczNaglowki(): HttpHeaders {
    console.log(this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
    return new HttpHeaders().set("Authorization", "Bearer " + this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
  }
}
