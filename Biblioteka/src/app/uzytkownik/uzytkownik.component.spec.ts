import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UzytkownikComponent } from './uzytkownik.component';

describe('UzytkownikComponent', () => {
  let component: UzytkownikComponent;
  let fixture: ComponentFixture<UzytkownikComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UzytkownikComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UzytkownikComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
