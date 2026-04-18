import { Component, inject, input, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ProductMetadata } from '@crams/features/product/product-metadata/product-metadata';
import { ProductResponsibilities } from '@crams/features/product/product-responsibilities/product-responsibilities';
import { ProductStatus } from '@crams/features/product/product-status/product-status';
import { ProductStore } from '@crams/stores/product-store';

@Component({
  selector: 'crams-product',
  imports: [ProductMetadata, ProductResponsibilities, ProductStatus, RouterOutlet],
  templateUrl: './product.html',
  styleUrl: './product.scss',
})
export class Product implements OnInit {
  readonly #productStore = inject(ProductStore);

  productId = input.required<string>();

  product = this.#productStore.product;

  ngOnInit(): void {
    this.#productStore.loadProduct(this.productId());
  }
}
