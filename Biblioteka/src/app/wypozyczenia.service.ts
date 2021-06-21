import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable, of } from 'rxjs';
import {map, tap} from 'rxjs/operators';
import { ksiazka } from './ksiazka.service';

export interface Paginacja{
  strona: number;
  ilosc: number;
}

export interface Wypozyczenie
{
    idWypozyczenia: number,
    dataWypozyczenia: Date,
    dataOddania: Date,
    ksiazkaID: number,
    uzytkownikID: number
}

@Injectable({
  providedIn: 'root'
})
export class WypozyczeniaService {
  private wybraneKsiazki: BehaviorSubject<ksiazka[]>= new BehaviorSubject<ksiazka[]>([]);
  constructor(private http: HttpClient) 
  { 
  }

  pobierzWypozyczenia(): Observable<Wypozyczenie[]>
  {
    return this.http.get<Wypozyczenie[]>("https://localhost:44383/api/Wypozyczenia");
  }

  getWypozyczenie(id:number): Observable<Wypozyczenie>
  {
      return this.http.get<Wypozyczenie>('https://localhost:44383/api/Wypozyczenia/'+id);
  }

 /* postWypozyczenia(wypozyczenie: Wypozyczenie): Observable<Wypozyczenie>
  {
    return this.http.post<Wypozyczenie>('https://localhost:44383/api/Wypozyczenia'+wypozyczenie);
  }*/

  deleteWypozyczenie(id:number):Observable<Wypozyczenie>
  {
    return this.http.delete<Wypozyczenie>('https://localhost:44383/api/Wypozyczenia/'+id);
  }
/*
  putWypozyczenie(id:number):Observable<Wypozyczenie>
  {
    return this.http.put<Wypozyczenie>('https://localhost:44383/api/Wypozyczenia/'+id);
  }*/
}
