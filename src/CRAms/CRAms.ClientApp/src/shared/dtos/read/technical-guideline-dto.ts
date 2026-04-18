/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { EntityDto } from "./entity-dto";
import { RequirementDto } from "./requirement-dto";

export interface TechnicalGuidelineDto extends EntityDto {
    requirements: RequirementDto[];
    version: string;
}
