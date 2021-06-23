import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ksiazka, KsiazkaService } from './ksiazka.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Biblioteka';

  constructor(private ksiazkaService:KsiazkaService, private route: ActivatedRoute) { }
  ngOnInit(): void {
  
  }
}
