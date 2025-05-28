import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-success-page',
  imports: [RouterModule],
  templateUrl: './success-page.component.html',
  styleUrl: './success-page.component.css'
})
export class SuccessPageComponent {

  constructor(private router:Router) {
    setTimeout(() => {
      this.navTo();
    }, 2000);
  }
  
  navTo(){
    this.router.navigate(["/profile"]);
  }

}
