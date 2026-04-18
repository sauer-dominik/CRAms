import { TestBed } from '@angular/core/testing';

import { ProductParticipantsStore } from './product-participants-store';

describe('ProductParticipantsStore', () => {
  let service: ProductParticipantsStore;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProductParticipantsStore);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
