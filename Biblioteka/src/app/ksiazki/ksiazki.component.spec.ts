import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KsiazkiComponent } from './ksiazki.component';

describe('KsiazkiComponent', () => {
  let component: KsiazkiComponent;
  let fixture: ComponentFixture<KsiazkiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KsiazkiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KsiazkiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
