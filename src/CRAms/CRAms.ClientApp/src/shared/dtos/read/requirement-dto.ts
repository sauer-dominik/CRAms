/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { NamedEntityDto } from "./named-entity-dto";
import { ItemDto } from "./item-dto";

export interface RequirementDto extends NamedEntityDto {
    isParent: boolean;
    requirementItems: ItemDto[];
    subRequirements: RequirementDto[] | null;
}
