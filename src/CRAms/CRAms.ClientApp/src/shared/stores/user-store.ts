import { inject, Injectable } from '@angular/core';
import { UserDto } from '@crams/dtos/read';
import { UserService } from '@crams/services/user-service';
import { tapResponse } from '@ngrx/operators';
import { patchState, signalState } from '@ngrx/signals';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { exhaustMap, pipe, tap } from 'rxjs';
import { BaseType } from './base-type';

type UserState = BaseType<UserDto>;
const initialState: UserState = {
  entity: undefined,
  isLoading: false,
};

@Injectable({
  providedIn: 'root',
})
export class UserStore {
  readonly #userService = inject(UserService);
  readonly #userState = signalState(initialState);

  readonly user = this.#userState.entity;
  readonly isLoading = this.#userState.isLoading;

  readonly loadUser = rxMethod<string>(
    pipe(
      tap(() => patchState(this.#userState, { isLoading: true })),
      exhaustMap((userId: string) => {
        return this.#userService.getUserById(userId).pipe(
          tapResponse({
            next: user => patchState(this.#userState, { entity: user }),
            error: console.error,
            finalize: () => patchState(this.#userState, { isLoading: false }),
          })
        );
      })
    )
  );
}
