/**
 * This is a TypeGen auto-generated file.
 * Any changes made to this file can be lost when this file is regenerated.
 */

import { NamedEntityDto } from "./named-entity-dto";
import { Role } from "../enums/role";

export interface UserDto extends NamedEntityDto {
    role: Role;
}
