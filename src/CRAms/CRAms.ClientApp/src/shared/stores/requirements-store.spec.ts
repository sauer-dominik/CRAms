import { TestBed } from '@angular/core/testing';

import { RequirementsStore } from './requirements-store';

describe('RequirementsStore', () => {
  let service: RequirementsStore;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RequirementsStore);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
