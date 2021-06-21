import { TestBed } from '@angular/core/testing';

import { WypozyczeniaService } from './wypozyczenia.service';

describe('WypozyczeniaService', () => {
  let service: WypozyczeniaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WypozyczeniaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
