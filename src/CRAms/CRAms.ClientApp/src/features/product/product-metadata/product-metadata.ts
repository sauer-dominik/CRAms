import { Component, input } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { ProductDto } from '@crams/dtos/read';

@Component({
  selector: 'crams-product-metadata',
  imports: [MatCardModule],
  templateUrl: './product-metadata.html',
  styleUrl: './product-metadata.scss',
})
export class ProductMetadata {
  product = input.required<ProductDto | undefined>();
}
