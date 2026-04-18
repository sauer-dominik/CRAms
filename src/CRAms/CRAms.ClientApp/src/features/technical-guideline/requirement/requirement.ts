import { Component, computed, inject, input, OnInit, signal } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatIcon } from '@angular/material/icon';
import { MatTabsModule } from '@angular/material/tabs';
import { RouterLink } from '@angular/router';
import { ItemType } from '@crams/dtos/enums/item-type';
import { Role } from '@crams/dtos/enums/role';
import { ItemDto } from '@crams/dtos/read';
import { RequirementItem } from '@crams/features/technical-guideline/requirement-item/requirement-item';
import { ProductStore, RequirementsStore } from '@crams/stores';
import { UserStore } from '@crams/stores/user-store';

interface RequirementTab {
  description: string;
  hide?: (items: ItemDto[]) => boolean;
  items: ItemDto[];
  name: string;
  type: ItemType;
}

type RoleTabMapping = { [key in Role]: ItemType };

@Component({
  selector: 'crams-requirement',
  imports: [MatButtonModule, MatCardModule, MatIcon, MatTabsModule, RequirementItem, RouterLink],
  templateUrl: './requirement.html',
  styleUrl: './requirement.scss',
  providers: [ProductStore, RequirementsStore],
})
export class Requirement implements OnInit {
  readonly #requirementsStore = inject(RequirementsStore);
  readonly #userStore = inject(UserStore);

  productId = input.required<string>();
  requirementId = input.required<string>();

  user = this.#userStore.user;

  isLoading = this.#requirementsStore.isLoading;
  requirement = computed(() => this.#requirementsStore.requirements()?.find(r => r.id === this.requirementId()));

  requirementTabs = computed(
    () =>
      [
        {
          description: 'Requirements must be met, only if the conditions apply to the product.',
          hide: (items: ItemDto[]) => this.isUndefinedOrEmpty(items),
          items: this.requirement()?.requirementItems.filter(ri => ri.type === ItemType.Condition) ?? [],
          name: 'Conditions',
          type: ItemType.Condition,
        },
        {
          description: 'Requirements to be met.',
          hide: (items: ItemDto[]) => this.isUndefinedOrEmpty(items),
          items: this.requirement()?.requirementItems.filter(ri => ri.type === ItemType.Requirement) ?? [],
          name: 'Requirements',
          type: ItemType.Requirement,
        },
        {
          description: 'Recommendations which should be met.',
          hide: (items: ItemDto[]) => this.isUndefinedOrEmpty(items),
          items: this.requirement()?.requirementItems.filter(ri => ri.type === ItemType.Recommendation) ?? [],
          name: 'Recommendation',
          type: ItemType.Recommendation,
        },
        {
          description: 'Assessments are used to evaluate whether the product meets the requirements.',
          hide: (items: ItemDto[]) => this.isUndefinedOrEmpty(items),
          items: this.requirement()?.requirementItems.filter(ri => ri.type === ItemType.Assessment) ?? [],
          name: 'Assessments',
          type: ItemType.Assessment,
        },
      ] as RequirementTab[]
  );

  roleTabMapping: RoleTabMapping = {
    [Role.Development]: ItemType.Requirement,
    [Role.Assessment]: ItemType.Assessment,
  };

  // Calculate Tab based on the assigned role and whether Conditions are present.
  initialTabIndex = computed(() =>
    this.requirementTabs()
      .filter(rt => !this.isUndefinedOrEmpty(rt.items))
      .findIndex(rt => Number(rt.type) === this.roleTabMapping[this.user()?.role ?? 0])
  );
  selectedIndex = signal<number | undefined>(undefined);
  selectedTabIndex = computed(() => this.selectedIndex() ?? this.initialTabIndex());

  ngOnInit(): void {
    if (!this.user()) {
      // TODO: provide real userId
      const userId = '6dab8173-6574-42ef-98b2-0822650df3bb';
      this.#userStore.loadUser(userId);
    }

    this.#requirementsStore.loadRequirements(this.productId());
  }

  isUndefinedOrEmpty(array: object[] | undefined): boolean {
    return !array || array.length === 0;
  }

  setSelectedTabIndex(index: number): void {
    this.selectedIndex.set(index);
  }
}
