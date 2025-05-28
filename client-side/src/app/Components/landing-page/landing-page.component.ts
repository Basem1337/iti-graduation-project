import { Component } from '@angular/core';
import { HeroComponent } from './hero/hero.component';
import { CategoriesComponent } from './categories/categories.component';
import { FreeGamesComponent } from './free-games/free-games.component';
import { SalesComponent } from './sales/sales.component';
import { ArrivalComponent } from './arrival/arrival.component';
import { GameService } from '../../Services/products.service';

@Component({
  selector: 'app-landing-page',
  imports: [HeroComponent,CategoriesComponent,FreeGamesComponent,SalesComponent,ArrivalComponent],
  templateUrl: './landing-page.component.html',
  styleUrl: './landing-page.component.css'
})
export class LandingPageComponent {

}
