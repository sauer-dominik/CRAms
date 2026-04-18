import { inject, Injectable } from '@angular/core';
import { ProductDto } from '@crams/dtos/read';
import { ProductService } from '@crams/services/product-service';
import { tapResponse } from '@ngrx/operators';
import { patchState, signalState } from '@ngrx/signals';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { exhaustMap, pipe, tap } from 'rxjs';
import { BaseType } from './base-type';

type ProductsState = BaseType<ProductDto[]>;

const initialState: ProductsState = {
  isLoading: false,
  entity: undefined,
};

@Injectable({
  providedIn: 'root',
})
export class ProductsStore {
  readonly #productService = inject(ProductService);
  readonly #productsState = signalState(initialState);

  readonly allProducts = this.#productsState.entity;
  readonly isLoading = this.#productsState.isLoading;

  readonly loadAllProducts = rxMethod<void>(
    pipe(
      tap(() => patchState(this.#productsState, { isLoading: true })),
      exhaustMap(() => {
        return this.#productService.getAllProducts().pipe(
          tapResponse({
            next: product => patchState(this.#productsState, { entity: product }),
            error: console.error,
            finalize: () => patchState(this.#productsState, { isLoading: false }),
          })
        );
      })
    )
  );
}
