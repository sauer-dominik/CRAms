import { Component, computed, inject, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIcon } from '@angular/material/icon';
import { MatToolbarModule } from '@angular/material/toolbar';
import { RouterLink } from '@angular/router';
import { Role } from '@crams/dtos/enums/role';
import { UserStore } from '@crams/stores/user-store';

@Component({
  selector: 'crams-navigation',
  imports: [MatButtonModule, MatIcon, MatToolbarModule, RouterLink],
  templateUrl: './navigation.html',
  styleUrl: './navigation.scss',
})
export class Navigation implements OnInit {
  readonly #userStore = inject(UserStore);

  isLoading = this.#userStore.isLoading;
  user = this.#userStore.user;
  userRole = computed(() => Role[this.user()?.role ?? Role.Development]);

  ngOnInit(): void {
    // TODO: provide real userId
    const userId = '6dab8173-6574-42ef-98b2-0822650df3bb';
    this.#userStore.loadUser(userId);
  }
}
