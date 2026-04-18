import { Component } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIcon } from '@angular/material/icon';

@Component({
  selector: 'crams-ai-fab',
  imports: [MatButtonModule, MatIcon],
  templateUrl: './ai-fab.html',
  styleUrl: './ai-fab.scss',
})
export class AIFab {}
