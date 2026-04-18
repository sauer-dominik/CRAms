import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { ProductDto, UserDto } from '@crams/dtos/read';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class ProductService {
  #httpClient = inject(HttpClient);

  #productsEndpoint = '/api/products';
  #participantsEndpoint = 'participants';

  getAllProducts(): Observable<ProductDto[]> {
    return this.#httpClient.get<ProductDto[]>(`${this.#productsEndpoint}/`);
  }

  getProductById(productId: string): Observable<ProductDto | undefined> {
    return this.#httpClient.get<ProductDto | undefined>(`${this.#productsEndpoint}/${productId}`);
  }

  getProductParticipants(productId: string): Observable<UserDto[]> {
    return this.#httpClient.get<UserDto[]>(`${this.#productsEndpoint}/${productId}/${this.#participantsEndpoint}`);
  }
}
