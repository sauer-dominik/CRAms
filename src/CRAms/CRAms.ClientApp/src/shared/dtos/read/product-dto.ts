/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { NamedEntityDto } from "./named-entity-dto";
import { ItemTaskDto } from "./item-task-dto";

export interface ProductDto extends NamedEntityDto {
    itemTasks: ItemTaskDto[];
    technicalGuidelineId: string;
}
