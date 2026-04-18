import { inject, Injectable } from '@angular/core';
import { ProductDto } from '@crams/dtos/read';
import { ProductService } from '@crams/services/product-service';
import { tapResponse } from '@ngrx/operators';
import { patchState, signalState } from '@ngrx/signals';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { exhaustMap, pipe, tap } from 'rxjs';
import { BaseType } from './base-type';

type ProductState = BaseType<ProductDto>;

const initialState: ProductState = {
  isLoading: false,
  entity: undefined,
};

@Injectable({ providedIn: 'root' })
export class ProductStore {
  readonly #productService = inject(ProductService);
  readonly #productState = signalState(initialState);

  readonly product = this.#productState.entity;
  readonly isLoading = this.#productState.isLoading;

  readonly loadProduct = rxMethod<string>(
    pipe(
      tap(() => patchState(this.#productState, { isLoading: true })),
      exhaustMap((productId: string) => {
        return this.#productService.getProductById(productId).pipe(
          tapResponse({
            next: product => patchState(this.#productState, { entity: product }),
            error: console.error,
            finalize: () => patchState(this.#productState, { isLoading: false }),
          })
        );
      })
    )
  );
}
