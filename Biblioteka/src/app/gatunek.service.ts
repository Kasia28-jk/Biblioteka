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
      console.log("..");
      return this.http.get<gatunek[]>('https://localhost:44383/api/Gatunki');
  }

  getGatunek(gatunekId:number):Observable<gatunek>
  {
    console.log("..");
    return this.http.get<gatunek>('https://localhost:44383/api/Gatunki/'+gatunekId);
  }

  postGatunek(gatunek:gatunek):Observable<gatunek>
  {
    return this.http.post<gatunek>('https://localhost:44383/api/Gatunki',gatunek);
  }

  deleteGatunek(gatunekId:number):Observable<gatunek>
  {
    return this.http.delete<gatunek>('https://localhost:44383/api/Gatunki/'+gatunekId);
  }
}
