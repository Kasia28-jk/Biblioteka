import { Component, Input, OnInit } from '@angular/core';
import { gatunek, GatunekService } from '../gatunek.service';

@Component({
  selector: 'app-gatunek',
  templateUrl: './gatunek.component.html',
  styleUrls: ['./gatunek.component.css']
})
export class GatunekComponent implements OnInit 
{
  gatunki: gatunek[]=[];
  constructor(private gatunekService:GatunekService) { }

  ngOnInit(): void {
    this.gatunekService.pobierzGatunki().subscribe(res=>this.gatunki=res);
  }

}