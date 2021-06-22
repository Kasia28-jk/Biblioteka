import { Directive, TemplateRef, ViewContainerRef } from '@angular/core';
import { AutoryzacjaService } from './autoryzacja.service';

@Directive({
  selector: '[appAutoryzacja]'
})
export class AutoryzacjaDirective {

  private templateJuzIstnieje = false;

  constructor(private templateRef: TemplateRef<any>, private vc: ViewContainerRef, private autoryzacjaService: AutoryzacjaService) { 
    autoryzacjaService.zmianaStanuUzytkownika.subscribe(() => this.sprawdzUzytkownika());
  }

  private sprawdzUzytkownika() {
    if(this.autoryzacjaService.pobierzZalogowanegoUzytkownika() != null) {
      if(!this.templateJuzIstnieje) {
        this.vc.createEmbeddedView(this.templateRef);
        this.templateJuzIstnieje = true;
      }
    } else {
      if(this.templateJuzIstnieje) {
        this.vc.clear();
        this.templateJuzIstnieje = false;
      }
    }
  }
}