import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ksiazka, KsiazkaService } from '../ksiazka.service';
import { WypozyczeniaService } from '../wypozyczenia.service';

@Component({
  selector: 'app-ksiazka',
  templateUrl: './ksiazka.component.html',
  styleUrls: ['./ksiazka.component.css']
})
export class KsiazkaComponent implements OnInit {
  @Input() ksiazka: ksiazka;
  id:number;
  constructor(private ksiazkaService:KsiazkaService, private wypozyczenia:WypozyczeniaService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    const id = Number.parseInt(this.route.snapshot.paramMap.get('id'));
    if(id>0){
    this.id=id;
    this.ksiazkaService.getKsiazke(id).subscribe(res=>this.ksiazka=res);
    }
  }

  DodajDoWypozyczen(id:number): void{
    //this.wypozyczenia.dodajDoWypozyczenia(id).subscribe();
  }

}
