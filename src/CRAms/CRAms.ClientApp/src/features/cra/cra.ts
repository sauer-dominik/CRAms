import { Component } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIcon } from '@angular/material/icon';

@Component({
  selector: 'crams-cra',
  imports: [MatButtonModule, MatIcon],
  templateUrl: './cra.html',
  styleUrl: './cra.scss',
})
export class CRA {}
