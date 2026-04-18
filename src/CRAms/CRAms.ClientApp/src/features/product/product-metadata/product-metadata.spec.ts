import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductMetadata } from './product-metadata';

describe('ProductMetadata', () => {
  let component: ProductMetadata;
  let fixture: ComponentFixture<ProductMetadata>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProductMetadata],
    }).compileComponents();

    fixture = TestBed.createComponent(ProductMetadata);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
