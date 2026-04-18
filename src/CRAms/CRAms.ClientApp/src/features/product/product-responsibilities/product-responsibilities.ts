import { Component, computed, inject, input, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { MatIcon } from '@angular/material/icon';
import { Role } from '@crams/dtos/enums';
import { ProductDto, UserDto } from '@crams/dtos/read';
import { ProductParticipantsStore } from '@crams/stores/product-participants-store';

interface ProductParticipantMapping {
  role: Role;
  participants: UserDto[];
}

@Component({
  selector: 'crams-product-responsibilities',
  imports: [MatButtonModule, MatCardModule, MatChipsModule, MatIcon],
  templateUrl: './product-responsibilities.html',
  styleUrl: './product-responsibilities.scss',
})
export class ProductResponsibilities implements OnInit {
  Role = Role;

  #productParticipantsStore = inject(ProductParticipantsStore);

  product = input.required<ProductDto | undefined>();

  displayedRoles = [Role.Assessment, Role.Development];

  productParticipants = this.#productParticipantsStore.productParticipants;

  productParticipantsMapping = computed(() =>
    this.displayedRoles.map<ProductParticipantMapping>(role => ({
      role: role,
      participants: this.productParticipants()?.filter(pp => pp.role === role) ?? [],
    }))
  );

  ngOnInit(): void {
    if (this.product()?.id) {
      this.#productParticipantsStore.loadProductParticipants(this.product()!.id);
    }
  }
}
