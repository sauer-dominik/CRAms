import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { TechnicalGuidelineDto } from '@crams/dtos/read';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class TechnicalGuidelineService {
  #httpClient = inject(HttpClient);

  #technicalGuidelinesEndpoint = '/api/technicalGuidelines';

  getTechnicalGuidelineByProductId(productId: string): Observable<TechnicalGuidelineDto | undefined> {
    return this.#httpClient.get<TechnicalGuidelineDto | undefined>(`${this.#technicalGuidelinesEndpoint}/${productId}`);
  }
}
