/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { EntityDto } from "./entity-dto";

export interface ItemTaskDto extends EntityDto {
    isApplicable: boolean;
    isCompleted: boolean;
    itemId: string;
    requirementId: string;
}
