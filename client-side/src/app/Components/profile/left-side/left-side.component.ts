import { Component } from '@angular/core';
import { GameCardComponent } from "../game-card/game-card.component";
import { GameService } from '../../../Services/products.service';
import { CommonModule } from '@angular/common';
import { LibraryService } from '../../../Services/library.service';
import { Game } from '../../../Models/LibraryItem';

@Component({
  selector: 'app-left-side',
  imports: [GameCardComponent, CommonModule],
  templateUrl: './left-side.component.html',
  styleUrl: './left-side.component.css'
})
export class LeftSideComponent {
  games: Game[] = [];
  errMsg: string = "";
  
  constructor(private libraryService: LibraryService) {}

  ngOnInit(): void {
    this.libraryService.getLibrary().subscribe({
      next:(res)=>{
        this.games = res.games
      },
      error:(err)=>{
        console.error(err);
        this.errMsg = err.error;
      }
    })
  }

  // loadGames(): void {
  //   this.productService.getAllGames().subscribe((data: any) => {
  //     this.games = data;
  //   });
  // }
}
