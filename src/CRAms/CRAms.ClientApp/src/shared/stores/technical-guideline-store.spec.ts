import { TestBed } from '@angular/core/testing';

import { TechnicalGuidelineStore } from './technical-guideline-store';

describe('TechnicalGuidelineStore', () => {
  let service: TechnicalGuidelineStore;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TechnicalGuidelineStore);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
