import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CRA } from './cra';

describe('CRA', () => {
  let component: CRA;
  let fixture: ComponentFixture<CRA>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CRA],
    }).compileComponents();

    fixture = TestBed.createComponent(CRA);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
