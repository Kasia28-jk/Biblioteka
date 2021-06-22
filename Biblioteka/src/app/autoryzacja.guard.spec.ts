import { TestBed } from '@angular/core/testing';

import { AutoryzacjaGuard } from './autoryzacja.guard';

describe('AutoryzacjaGuard', () => {
  let guard: AutoryzacjaGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(AutoryzacjaGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
