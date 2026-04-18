import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductResponsibilities } from './product-responsibilities';

describe('ProductResponsibilities', () => {
  let component: ProductResponsibilities;
  let fixture: ComponentFixture<ProductResponsibilities>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProductResponsibilities],
    }).compileComponents();

    fixture = TestBed.createComponent(ProductResponsibilities);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
