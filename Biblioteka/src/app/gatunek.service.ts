import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

export interface gatunek
{
  gatunekId: number;
  nazwa: string;
 // ksiazki: ksiazki[];
}

@Injectable({
  providedIn: 'root'
})
export class GatunekService {

  constructor(private http: HttpClient) { }

  pobierzGatunki():Observable<gatunek[]>
  {
      return this.http.get<gatunek[]>('https://localhost:44383/api/Gatunek'/*,{ headers: this.dolaczNaglowki() }*/);
  }

  getGatunek(gatunekId:number):Observable<gatunek>
  {
    console.log("..");
    return this.http.get<gatunek>('https://localhost:44383/api/Gatunek/'+gatunekId/*,{ headers: this.dolaczNaglowki() }*/);
  }

  postGatunek(gatunek:gatunek):Observable<gatunek>
  {
    return this.http.post<gatunek>('https://localhost:44383/api/Gatunek',gatunek/*,{ headers: this.dolaczNaglowki() }*/);
  }

  deleteGatunek(gatunekId:number):Observable<gatunek>
  {
    return this.http.delete<gatunek>('https://localhost:44383/api/Gatunek/'+gatunekId/*,{ headers: this.dolaczNaglowki() }*/);
  }
}
