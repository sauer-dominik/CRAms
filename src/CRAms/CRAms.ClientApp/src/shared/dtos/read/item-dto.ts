/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { EntityDto } from "./entity-dto";
import { ItemType } from "../enums/item-type";

export interface ItemDto extends EntityDto {
    description: string;
    type: ItemType;
}
