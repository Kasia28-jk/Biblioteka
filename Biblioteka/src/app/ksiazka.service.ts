import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

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

  constructor(private http: HttpClient) { }

  pobierzKsiazki():Observable<ksiazka[]>
  {
      console.log("..");
      return this.http.get<ksiazka[]>('https://localhost:44383/api/Ksiazki');
  }

  getKsiazke(id:number):Observable<ksiazka>
  {
    console.log("..");
    return this.http.get<ksiazka>('https://localhost:44383/api/Ksiazki/'+id);
  }

  postKsiazka(ksiazka:ksiazka):Observable<ksiazka>
  {
    return this.http.post<ksiazka>('https://localhost:44383/api/Ksiazki',ksiazka);
  }

  deleteKsiazka(id:number):Observable<ksiazka>
  {
    return this.http.delete<ksiazka>('https://localhost:44383/api/Ksiazki/'+id);
  }
}
