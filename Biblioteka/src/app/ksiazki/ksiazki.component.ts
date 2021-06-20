import { Component, OnInit } from '@angular/core';
import { ksiazka, KsiazkaService } from '../ksiazka.service';

@Component({
  selector: 'app-ksiazki',
  templateUrl: './ksiazki.component.html',
  styleUrls: ['./ksiazki.component.css']
})
export class KsiazkiComponent implements OnInit {

  ksiazki: ksiazka[] = [];
  constructor(private ksiazkiservice:KsiazkaService) { }

  ngOnInit(): void {
  }

}
