import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AutoryzacjaService, Uzytkownik } from '../autoryzacja.service';

@Component({
  selector: 'app-uzytkownik',
  templateUrl: './uzytkownik.component.html',
  styleUrls: ['./uzytkownik.component.css']
})
export class UzytkownikComponent implements OnInit {

user: Uzytkownik = {
  UzytkownikId: null,
  Status: null,
  Login: null,
  Haslo: null
}

zalogowany:boolean = false;

blad: string;

  constructor(private autoryzacjaService: AutoryzacjaService, private router: Router) {
   }

  ngOnInit(): void {
  }

  onSubmit() {
    console.log('asdasasd');
    this.autoryzacjaService.login(this.user).subscribe(res => {
      if(res) {
        this.zalogowany=true;
        this.router.navigateByUrl('');
      } else {
        this.blad = "Błędny login lub hasło!";
      }
    });
  }

}
