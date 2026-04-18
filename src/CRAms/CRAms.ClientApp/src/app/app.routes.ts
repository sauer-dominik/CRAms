import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    loadComponent: () => import('@crams/features/accessibility/accessibility').then(c => c.Accessibility),
    path: 'accessibility',
  },
  {
    loadComponent: () => import('@crams/features/cra/cra').then(c => c.CRA),
    path: 'cra',
  },
  {
    loadComponent: () => import('@crams/features/data-protection/data-protection').then(c => c.DataProtection),
    path: 'data-protection',
  },
  {
    loadComponent: () => import('@crams/features/imprint/imprint').then(c => c.Imprint),
    path: 'imprint',
  },
  {
    loadComponent: () => import('@crams/features/products-list/products-list').then(c => c.ProductsList),
    path: 'products',
    pathMatch: 'full',
  },
  {
    loadComponent: () => import('@crams/features/create-product/create-product').then(c => c.CreateProduct),
    path: 'products/new',
    pathMatch: 'full',
  },
  {
    children: [
      {
        loadComponent: () =>
          import('@crams/features//technical-guideline/technical-guideline').then(c => c.TechnicalGuideline),
        path: '',
        pathMatch: 'full',
      },
      {
        loadComponent: () =>
          import('@crams/features/technical-guideline/requirement/requirement').then(c => c.Requirement),
        path: 'requirements/:requirementId',
      },
      {
        path: '**',
        redirectTo: '',
      },
    ],
    loadComponent: () => import('@crams/features/product/product').then(c => c.Product),
    path: 'products/:productId',
  },
  {
    path: '**',
    redirectTo: 'products',
  },
];
