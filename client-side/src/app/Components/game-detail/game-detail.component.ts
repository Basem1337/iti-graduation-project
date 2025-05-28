
import { Component, OnInit } from '@angular/core';
import { Game } from '../../Module/GameModule';
import { CommonModule } from '@angular/common';
import { GameService } from '../../Services/products.service';
import { ActivatedRoute, RouterModule } from '@angular/router';
import { UsersService } from '../../Services/users.service';
import { AuthService } from '../../Services/auth.services'; 
import { CartService } from '../../Services/cart.services';

@Component({
  selector: 'app-game-detail',
  standalone: true,
  imports: [CommonModule, RouterModule],  
  templateUrl: './game-detail.component.html',
  styleUrls: ['./game-detail.component.css']
})
export class GameDetailComponent implements OnInit {
  game: Game | null = null;
  isLoading = true;
  error: string | null = null;
  popUpMsg: string | null = null;
  userId: string | null = null;
  popUpType:"success" | "fail" = "fail";

  constructor(
    private readonly route: ActivatedRoute,
    private readonly gameService: GameService,
    private readonly userService: UsersService,
    private authService: AuthService,
    private cartService: CartService
  ) { }

  ngOnInit(): void {
    console.log(this.game);
    this.userId = this.authService.getUserIdFromToken();
    
    this.route.params.subscribe(params => {
      const gameId = params['id']; 
      this.loadGameDetails(gameId);
    });
  }

  loadGameDetails(gameId: number): void {
    this.isLoading = true;
    this.error = null;
    

    this.gameService.getGameById(gameId).subscribe({
      next: (data) => {
        console.log(data);
        
        this.game = data;
        this.isLoading = false;
        console.log(data);
        
      },
      error: (err) => {
        this.error = 'Failed to load game details. Please try again.';
        this.isLoading = false;
        console.error('Error fetching game details:', err);
      }
    });
  }

  // addToCart(): void {
  //   console.log("Cart");
    
  //   if (!this.userId || !this.game?.id) return;

  //   this.userService.addToCart(this.userId, this.game.id).subscribe({
  //     next: () => {
  //       console.log('Added to cart!');
  //     },
  //     error: () => {
  //       console.error('Failed to add to cart.');
  //     }
  //   });
  // }

  addToCart(productId:string){
    if (this.game) {
      console.log(this.game);
    }
    this.cartService.addToCart(productId).subscribe({
      next:(res)=>{
        this.popUpType = "success"
        this.popUpMsg = `${this.game?.gameName} has been added to your cart successfully`
      },
      error:(res)=>{
        this.popUpMsg = res.error

      }
    })
  }

  addToWishlist(): void {
    console.log("wishlist");
    if (!this.userId || !this.game?.id) return;

    this.userService.addToWishlist(this.userId, this.game.id).subscribe({
      next: () => {
        console.log('Added to wishlist!');
      },
      error: () => {

        console.error('Failed to add to wishlist.');
      }
    });
  }

  openTrailer(): void {
    if (this.game?.trailer) {
      const url = this.game.trailer.startsWith('http') ? this.game.trailer : `https://${this.game.trailer}`;
      window.open(url, '_blank');
      console.log(url);
      
    } else {
      console.error('Trailer URL is not available');
    }
  }
}
