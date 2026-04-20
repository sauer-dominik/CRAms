import { Component, input } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIcon } from '@angular/material/icon';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatTabsModule } from '@angular/material/tabs';
import { MatTooltipModule } from '@angular/material/tooltip';
import { ItemType } from '@crams/dtos/enums/item-type';
import { ItemDto, ItemTaskDto } from '@crams/dtos/read';

@Component({
  selector: 'crams-requirement-item',
  imports: [MatButtonModule, MatIcon, MatSlideToggleModule, MatTabsModule, MatTooltipModule],
  templateUrl: './requirement-item.html',
  styleUrl: './requirement-item.scss',
})
export class RequirementItem {
  requirementItem = input.required<ItemDto>();
  itemTask = input.required<ItemTaskDto | undefined>();

  isCondition(item: ItemDto): boolean {
    return item.type === ItemType.Condition;
  }
}
