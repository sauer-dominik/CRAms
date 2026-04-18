import { TestBed } from '@angular/core/testing';

import { TechnicalGuidelineService } from './technical-guideline-service';

describe('TechnicalGuidelineService', () => {
  let service: TechnicalGuidelineService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TechnicalGuidelineService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
