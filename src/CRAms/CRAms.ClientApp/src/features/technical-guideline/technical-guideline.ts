import { Component, computed, inject, input, OnInit } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatIconModule } from '@angular/material/icon';
import { RouterModule } from '@angular/router';
import { ItemTaskDto, RequirementDto } from '@crams/dtos/read';
import { ProductStore, RequirementsStore } from '@crams/stores';

@Component({
  selector: 'crams-technical-guideline',
  imports: [MatButtonModule, MatExpansionModule, MatIconModule, RouterModule],
  templateUrl: './technical-guideline.html',
  styleUrl: './technical-guideline.scss',
})
export class TechnicalGuideline implements OnInit {
  #productStore = inject(ProductStore);
  #requirementsStore = inject(RequirementsStore);

  productId = input.required<string>();

  product = this.#productStore.product;

  itemTasks = computed(() => this.product()?.itemTasks ?? []);

  completedItemCount = computed(() => 2);
  maxItemCount = computed(() => 13);
  notApplicableCount = computed(() => 1);

  requirements = this.#requirementsStore.requirements;

  ngOnInit(): void {
    if (!this.#productStore.product()) {
      this.#productStore.loadProduct(this.productId());
    }

    this.#requirementsStore.loadRequirements(this.productId());
  }

  getCompletedItemCount(requirement: RequirementDto): number {
    if (requirement.isParent) {
      const completedItemTasks =
        requirement.subRequirements
          ?.map(sr => this.getItemTasksForRequirement(sr))
          ?.map(its => its.every(it => it.isCompleted))
          ?.filter(completed => completed) ?? [];

      return completedItemTasks.length;
    }

    return this.getItemTasksForRequirement(requirement).filter(it => it.isCompleted).length;
  }

  getMaxItemCount(requirement: RequirementDto): number {
    if (requirement.isParent) {
      return requirement.subRequirements?.length ?? 0;
    }

    return this.getItemTasksForRequirement(requirement).length;
  }

  getNotApplicableCount(requirement: RequirementDto): number {
    if (requirement.isParent) {
      const notApplicableItemTasks =
        requirement.subRequirements
          ?.map(sr => this.getItemTasksForRequirement(sr))
          ?.map(its => its.some(it => !it.isApplicable))
          ?.filter(completed => completed) ?? [];

      return notApplicableItemTasks.length;
    }

    return this.getItemTasksForRequirement(requirement).filter(it => !it.isApplicable).length;
  }

  private getItemTasksForRequirement(requirement: RequirementDto): ItemTaskDto[] {
    return this.itemTasks().filter(it => it.requirementId === requirement.id);
  }
}
