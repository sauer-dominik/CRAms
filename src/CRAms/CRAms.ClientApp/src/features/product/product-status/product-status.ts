import { Component, inject, input } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatChipsModule } from '@angular/material/chips';
import { MatIcon } from '@angular/material/icon';
import { ProductDto } from '@crams/dtos/read';
import { ProductStore } from '@crams/stores';

@Component({
  selector: 'crams-product-status',
  imports: [MatButtonModule, MatCardModule, MatCheckboxModule, MatChipsModule, MatIcon],
  templateUrl: './product-status.html',
  styleUrl: './product-status.scss',
})
export class ProductStatus {
  readonly #productStore = inject(ProductStore);

  product = input.required<ProductDto | undefined>();

  isLoading = this.#productStore.isLoading;
}
