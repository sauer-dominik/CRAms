import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TechnicalGuideline } from './technical-guideline';

describe('TechnicalGuideline', () => {
  let component: TechnicalGuideline;
  let fixture: ComponentFixture<TechnicalGuideline>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TechnicalGuideline],
    }).compileComponents();

    fixture = TestBed.createComponent(TechnicalGuideline);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
