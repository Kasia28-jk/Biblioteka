import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AutoryzacjaService } from './autoryzacja.service';

export interface ksiazka
{
    id: number;
    tytul: string;
    imie: string;
    nazwisko: string;
    wydawnictwo: string;
    liczbaStron: string;
    ebook: boolean;
}

@Injectable({
  providedIn: 'root'
})
export class KsiazkaService {

  constructor(private http: HttpClient, private autoryzacjaService: AutoryzacjaService) { }

  pobierzKsiazki():Observable<ksiazka[]>
  {
      console.log("..");
      return this.http.get<ksiazka[]>('https://localhost:44383/api/Ksiazki',{ headers: this.dolaczNaglowki() });
  }

  getKsiazke(id:number):Observable<ksiazka>
  {
    console.log("..");
    return this.http.get<ksiazka>('https://localhost:44383/api/Ksiazki/'+id,{ headers: this.dolaczNaglowki() });
  }

  postKsiazka(ksiazka:ksiazka):Observable<ksiazka>
  {
    return this.http.post<ksiazka>('https://localhost:44383/api/Ksiazki',ksiazka,{ headers: this.dolaczNaglowki() });
  }

  deleteKsiazka(id:number):Observable<ksiazka>
  {
    return this.http.delete<ksiazka>('https://localhost:44383/api/Ksiazki/'+id,{ headers: this.dolaczNaglowki() });
  }

  private dolaczNaglowki(): HttpHeaders {
    console.log(this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
    return new HttpHeaders().set("Authorization", "Bearer " + this.autoryzacjaService.pobierzZalogowanegoUzytkownika()?.token);
  }
}
