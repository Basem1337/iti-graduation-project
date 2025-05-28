import { Routes } from '@angular/router';
import { LoginComponent } from './Components/login/login.component';
import { SignupComponent } from './Components/signup/signup.component';
import { AboutPageComponent } from './Components/about/about-page.component';
import { GameDetailComponent } from './Components/game-detail/game-detail.component';
import { ErrorPageComponent } from './Components/error-page/error-page.component';
import { ProfileComponent } from './Components/profile/profile.component';
import { ProductsComponent } from './Components/products/products.component';
import { LandingPageComponent } from './Components/landing-page/landing-page.component';
import { CheckOutPageComponent } from './Components/check-out-page/check-out-page.component';
import { ProcessingPageComponent } from './Components/processing-page/processing-page.component';
import { SuccessPageComponent } from './Components/success-page/success-page.component';

export const routes: Routes = [
    {path:'',component:LandingPageComponent},
    {path:'home',component:LandingPageComponent},
    {path:'products', component: ProductsComponent },
    {path:'login',component:LoginComponent},
    {path:'signup',component:SignupComponent},
    {path:'about',component:AboutPageComponent},
    {path:'games',component:ProductsComponent},
    {path:'games/:id',component:GameDetailComponent},
    {path:'cart',component:CheckOutPageComponent},
    {path:'profile',component:ProfileComponent},
    {path:'process',component:ProcessingPageComponent},
    {path:'success',component:SuccessPageComponent},
    {path:'**',component:ErrorPageComponent}
];