import { Component, computed, inject } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { RouterLink } from '@angular/router';
import { ProductsStore } from '@crams/stores/products-store';

@Component({
  selector: 'crams-products-list',
  imports: [MatButtonModule, MatTableModule, RouterLink],
  templateUrl: './products-list.html',
  styleUrl: './products-list.scss',
})
export class ProductsList {
  productsStore = inject(ProductsStore);

  dataSource = computed(() => new MatTableDataSource(this.productsStore.allProducts() ?? []));
  displayedColumns = ['name'];

  constructor() {
    this.productsStore.loadAllProducts();
  }
}
