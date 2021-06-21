import { Component, OnInit } from '@angular/core';
import { ksiazka } from '../ksiazka.service';
import { WypozyczeniaService } from '../wypozyczenia.service';

@Component({
  selector: 'app-wypozyczenia',
  templateUrl: './wypozyczenia.component.html',
  styleUrls: ['./wypozyczenia.component.css']
})
export class WypozyczeniaComponent implements OnInit {

  wyswietlZawartosc: boolean=true;

  ksiazki: ksiazka[]=[];

  constructor(private wypozyczeniaService: WypozyczeniaService) { }

  ngOnInit(): void {
    this.wypozyczeniaService.pobierzWypozyczenia().subscribe(res=>this.ksiazki=res);
  }

  onClick()
  {
    console.log("...");
    this.wypozyczeniaService.wyczyscWypozyczenia().subscribe();
  }

  wyswietl(): void{
    this.wyswietlZawartosc=!this.wyswietlZawartosc;
  }

}
