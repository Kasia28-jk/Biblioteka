import { TestBed } from '@angular/core/testing';

import { AutoryzacjaService } from './autoryzacja.service';

describe('AutoryzacjaService', () => {
  let service: AutoryzacjaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AutoryzacjaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
