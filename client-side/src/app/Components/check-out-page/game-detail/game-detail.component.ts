import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { CartService } from '../../../Services/cart.services';
import { CartItem } from '../../../Models/CartItem';

@Component({
  selector: 'app-game-detail',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './game-detail.component.html',
  styleUrl: './game-detail.component.css'
})
export class GameDetailComponent {
  @Input() gameName!: string;
  @Input() gamePoster!: string;
  @Input() gamePrice!: number;
  @Input() gameCompany!: string;
  
  // @Input() cart!:CartItem[]

  @Input() productId!:string

  @Output() removeEvent=new EventEmitter()

  constructor(private cartService:CartService) {
    
  }

  deleteCartItem(productId:string){
    this.cartService.removeItemFromCart(productId).subscribe({
      next:(res)=>{
        this.removeEvent.emit(res.items)
      },
      error:(res)=>{

      }
    })
  }
}
