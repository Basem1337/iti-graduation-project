import { Component} from '@angular/core';
import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';


import { Router, RouterOutlet } from '@angular/router';
import { SignupComponent } from './Components/signup/signup.component';
import { LoginComponent } from './Components/login/login.component';
import { HeaderLoggedComponent } from './Components/header-logged/header-logged.component';
import { CommonModule } from '@angular/common';
import { LandingPageComponent } from './Components/landing-page/landing-page.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  // imports: [HeaderComponent, FooterComponent, RouterOutlet, ProfileComponent , AboutPageComponent,CheckOutPageComponent, ProcessingPageComponent, SuccessPageComponent,ErrorPageComponent]
  
  imports: [HeaderComponent,
    FooterComponent,
    RouterOutlet,
    SignupComponent,
    LoginComponent,
    HeaderLoggedComponent,
    LandingPageComponent,
    CommonModule],
})
export class AppComponent {
  token = localStorage.getItem("token");

  constructor(private router:Router) {
    
  }

  ngOnInit(){
    if (!this.token) {    
      this.router.navigate(['/login'])
    }
  }
}
