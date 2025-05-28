import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-processing-page',
  imports: [RouterModule],
  templateUrl: './processing-page.component.html',
  styleUrl: './processing-page.component.css'
})
export class ProcessingPageComponent {

  constructor(private router:Router) {
    setTimeout(() => {
      this.navTo();
    }, 2000);
  }

  navTo(){
    this.router.navigate(["/success"]);
  }
  
}
