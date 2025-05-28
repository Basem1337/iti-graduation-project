import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { CheckoutService } from '../../../Services/checkout.service';

@Component({
  selector: 'app-left-side',
  imports: [RouterModule],
  templateUrl: './left-side.component.html',
  styleUrl: './left-side.component.css'
})
export class LeftSideComponent {

  constructor(private checkoutService:CheckoutService) {
    
  }

  checkout(){
    this.checkoutService.checkout().subscribe({
      next:(res)=>{

      },
      error:(res)=>{

      },
    })
  }
}
