import { TestBed } from '@angular/core/testing';

import { KsiazkaService } from './ksiazka.service';

describe('KsiazkaService', () => {
  let service: KsiazkaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(KsiazkaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
