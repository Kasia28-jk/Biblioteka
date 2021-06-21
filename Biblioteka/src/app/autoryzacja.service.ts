import { EventEmitter, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { of } from 'rxjs';

export interface Uzytkownik{
  UzytkownikId: number;
  Status: string;
  Login: string;
  Haslo: string;
}

export interface LoginRes {
  token: string;
  rola: string;
}

@Injectable({
  providedIn: 'root'
})
export class AutoryzacjaService {

  zmianaStanuUzytkownika: EventEmitter<void> = new EventEmitter<void>();

  constructor(private http: HttpClient) { }

  login(login: Uzytkownik): Observable<boolean> {
    return this.http.post<LoginRes>("https://localhost:44383/api/Uzytkownik", login).pipe(map(res => {
      sessionStorage.setItem('uzytkownik', JSON.stringify(res));
      this.zmianaStanuUzytkownika.emit();
      return true;
    }), catchError(error => {
      return of(false);
    }));
  }
}
