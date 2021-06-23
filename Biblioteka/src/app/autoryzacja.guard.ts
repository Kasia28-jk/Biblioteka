import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { AutoryzacjaService } from './autoryzacja.service';

@Injectable({
  providedIn: 'root'
})
export class AutoryzacjaGuard implements CanActivate {
  constructor(private autoryzacjaService: AutoryzacjaService, private router: Router){
  }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      const user = this.autoryzacjaService.pobierzZalogowanegoUzytkownika();
      if(user == null) {
        this.router.navigateByUrl('logowanie');
      } else {
        if(route.data?.dozwolonaRola != null) {
          return route.data.dozwolonaRola == user.rola;
        }
      }  
      return user != null;
  }
}

