import { EventEmitter, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { of } from 'rxjs';

export interface Uzytkownik
{
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
    console.log("---");
    return this.http.post<LoginRes>("https://localhost:44383/api/Login", login).pipe(map(res => {
      sessionStorage.setItem('uzytkownik', JSON.stringify(res));
      this.zmianaStanuUzytkownika.emit();
      return true;
    }), catchError(error => {
      return of(false);
    }));
  }

  wyloguj() {
    sessionStorage.removeItem('uzytkownik');
    this.zmianaStanuUzytkownika.emit();
  }

  pobierzZalogowanegoUzytkownika(): LoginRes {
    let loginres = JSON.parse(sessionStorage.getItem('uzytkownik')) as LoginRes;
    if(loginres != null && this.czyTokenJestPrzestarzaly(loginres.token)) {
      loginres = null;
      this.wyloguj();
    }
    return loginres;
  }

  private czyTokenJestPrzestarzaly(token: string): boolean {
    token.split('.').forEach(c => {
      try {
        console.log(atob(c));
      } catch {
        console.log('Oryginał: ', c);
      }
    });

    let dataWaznosci = (JSON.parse(atob(token.split('.')[1]))).exp;
    let obecnyCzas = (Math.floor((new Date).getTime() / 1000));

    return obecnyCzas >= dataWaznosci;
  }
}
