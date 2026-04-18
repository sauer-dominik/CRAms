import { inject, Injectable } from '@angular/core';
import { TechnicalGuidelineDto } from '@crams/dtos/read';
import { TechnicalGuidelineService } from '@crams/services/technical-guideline-service';
import { tapResponse } from '@ngrx/operators';
import { patchState, signalState } from '@ngrx/signals';
import { rxMethod } from '@ngrx/signals/rxjs-interop';
import { exhaustMap, pipe, tap } from 'rxjs';

type TechnicalGuidelineServiceState = {
  isLoading: boolean;
  technicalGuideline: TechnicalGuidelineDto | null;
};

const initialState: TechnicalGuidelineServiceState = {
  isLoading: false,
  technicalGuideline: null,
};

@Injectable({ providedIn: 'root' })
export class TechnicalGuidelineStore {
  readonly #technicalGuidelineService = inject(TechnicalGuidelineService);
  readonly #technicalGuidelineState = signalState(initialState);

  readonly technicalGuideline = this.#technicalGuidelineState.technicalGuideline;
  readonly isLoading = this.#technicalGuidelineState.isLoading;

  readonly loadTechnicalGuideline = rxMethod<string>(
    pipe(
      tap(() => patchState(this.#technicalGuidelineState, { isLoading: true })),
      exhaustMap((productId: string) => {
        return this.#technicalGuidelineService.getTechnicalGuidelineByProductId(productId).pipe(
          tapResponse({
            next: technicalGuideline =>
              patchState(this.#technicalGuidelineState, { technicalGuideline: technicalGuideline }),
            error: console.error,
            finalize: () => patchState(this.#technicalGuidelineState, { isLoading: false }),
          })
        );
      })
    )
  );
}
