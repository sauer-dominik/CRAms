import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductStatus } from './product-status';

describe('ProductStatus', () => {
  let component: ProductStatus;
  let fixture: ComponentFixture<ProductStatus>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProductStatus],
    }).compileComponents();

    fixture = TestBed.createComponent(ProductStatus);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
