import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AIFab } from '@crams/features/ai-fab/ai-fab';
import { Navigation } from '@crams/features/navigation/navigation';

@Component({
  selector: 'crams-root',
  imports: [RouterOutlet, Navigation, AIFab],
  templateUrl: './app.html',
  styleUrl: './app.scss',
})
export class App {
  protected readonly title = signal('CRAms');
}
