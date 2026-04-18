import { Component, signal } from '@angular/core';
import { form, FormField, required } from '@angular/forms/signals';
import { MatButtonModule } from '@angular/material/button';
import { MatFormField, MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatStepperModule } from '@angular/material/stepper';
import { Classification } from '@crams/dtos/enums';
import { CreateProductDto } from '@crams/dtos/write/create-product-dto';
import { ProductClassificationMappings } from '@crams/models/product-classification-mappings';

// Native text input control does not allow null as empty value,
// see https://angular.dev/guide/forms/signals/models#initializing-all-fields.
// type CreateProductDtoInternal = NonNullable<CreateProductDto>;
// However since this seems not to be working, create a copy of that interface with nonnullable description.
interface CreateProductDtoInternal {
  description: string;
  name: string;
}

interface ProductClassificationInternal {
  classification: Classification;
}

@Component({
  selector: 'crams-create-product',
  imports: [FormField, MatButtonModule, MatInputModule, MatFormField, MatSelectModule, MatStepperModule],
  templateUrl: './create-product.html',
  styleUrl: './create-product.scss',
})
export class CreateProduct {
  Classification = Classification;
  classifications = Object.keys(Classification).filter(c => isNaN(Number(c)));

  productClassificationMappings = ProductClassificationMappings;

  productClassificationModel = signal<ProductClassificationInternal>({
    classification: Classification.Product,
  });
  productClassificationForm = form(this.productClassificationModel);

  productMetadataModel = signal<CreateProductDtoInternal>({
    description: '',
    name: '',
  });
  productMetadataForm = form(this.productMetadataModel, schemaPath => {
    required(schemaPath.name, { message: 'Productname is required.' });
  });

  transform(createProductDto: CreateProductDtoInternal): CreateProductDto {
    return {
      description: createProductDto.description.length === 0 ? null : createProductDto.description,
      name: createProductDto.name,
    };
  }
}
