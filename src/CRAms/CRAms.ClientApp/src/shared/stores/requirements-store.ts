import { inject, Injectable } from '@angular/core';
import { RequirementDto } from '@crams/dtos/read';
import { TechnicalGuidelineService } from '@crams/services/technical-guideline-service';
import { tapResponse } from '@ngrx/operators';
import { patchState, signalState } from '@ngrx/signals';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { exhaustMap, pipe, tap } from 'rxjs';
import { BaseType } from './base-type';

type RequirementsState = BaseType<RequirementDto[]>;

const initialState: RequirementsState = {
  isLoading: false,
  entity: undefined,
};

@Injectable({ providedIn: 'root' })
export class RequirementsStore {
  readonly #technicalGuidelineService = inject(TechnicalGuidelineService);
  readonly #requirementsState = signalState(initialState);

  readonly requirements = this.#requirementsState.entity;
  readonly isLoading = this.#requirementsState.isLoading;

  readonly loadRequirements = rxMethod<string>(
    pipe(
      tap(() => patchState(this.#requirementsState, { isLoading: true })),
      exhaustMap((productId: string) => {
        return this.#technicalGuidelineService.getTechnicalGuidelineByProductId(productId).pipe(
          tapResponse({
            next: technicalGuideline => {
              // Flatten all Requirements into single array
              return patchState(this.#requirementsState, {
                entity: technicalGuideline?.requirements
                  .flatMap(r => [r, r.subRequirements?.filter(r => !!r) ?? []])
                  .flatMap(r => r),
              });
            },
            error: console.error,
            finalize: () => patchState(this.#requirementsState, { isLoading: false }),
          })
        );
      })
    )
  );
}
