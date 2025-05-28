import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';
import { GameService } from '../../../Services/products.service';

@Component({
  selector: 'app-game-card',
  imports: [CommonModule],
  templateUrl: './game-card.component.html',
  styleUrl: './game-card.component.css'
})
export class GameCardComponent {
  @Input() gameName!:string;
  @Input() gamePoster!:string;
}
