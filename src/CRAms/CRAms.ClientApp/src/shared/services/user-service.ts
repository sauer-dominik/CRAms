import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { UserDto } from '@crams/dtos/read';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  #httpClient = inject(HttpClient);

  #usersEndpoint = '/api/users';

  getUserById(userId: string): Observable<UserDto | undefined> {
    return this.#httpClient.get<UserDto | undefined>(`${this.#usersEndpoint}/${userId}`);
  }
}
