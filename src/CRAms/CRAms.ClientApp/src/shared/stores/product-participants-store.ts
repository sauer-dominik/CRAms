import { inject, Injectable } from '@angular/core';
import { UserDto } from '@crams/dtos/read';
import { ProductService } from '@crams/services/product-service';
import { tapResponse } from '@ngrx/operators';
import { patchState, signalState } from '@ngrx/signals';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { exhaustMap, pipe, tap } from 'rxjs';
import { BaseType } from './base-type';

type ProductState = BaseType<UserDto[]>;

const initialState: ProductState = {
  isLoading: false,
  entity: undefined,
};

@Injectable({
  providedIn: 'root',
})
export class ProductParticipantsStore {
  readonly #productService = inject(ProductService);
  readonly #productParticipantsState = signalState(initialState);

  readonly productParticipants = this.#productParticipantsState.entity;
  readonly isLoading = this.#productParticipantsState.isLoading;

  readonly loadProductParticipants = rxMethod<string>(
    pipe(
      tap(() => patchState(this.#productParticipantsState, { isLoading: true })),
      exhaustMap((productId: string) => {
        return this.#productService.getProductParticipants(productId).pipe(
          tapResponse({
            next: productParticipants => patchState(this.#productParticipantsState, { entity: productParticipants }),
            error: console.error,
            finalize: () => patchState(this.#productParticipantsState, { isLoading: false }),
          })
        );
      })
    )
  );
}
