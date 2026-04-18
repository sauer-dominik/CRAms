import { ProductClassifications } from '@crams/dtos/constants';
import { Classification } from '@crams/dtos/enums';

export const ProductClassificationMappings: { [key: string]: string[] } = {
  [Classification[Classification.Product]]: ProductClassifications.products,
  [Classification[Classification.ProductWithDigitalElements]]: ProductClassifications.productsWithDigitalElements,
  [Classification[Classification.ImportantProductWithDigitalElementsClassOne]]:
    ProductClassifications.importantProductWithDigitalElementsClassOne,
  [Classification[Classification.ImportantProductWithDigitalElementsClassTwo]]:
    ProductClassifications.importantProductWithDigitalElementsClassTwo,
  [Classification[Classification.CriticalProductsWithDigitalElements]]:
    ProductClassifications.criticalProductsWithDigitalElements,
};
