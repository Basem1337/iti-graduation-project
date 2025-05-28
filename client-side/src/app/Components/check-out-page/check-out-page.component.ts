import { Component } from '@angular/core';
import { LeftSideComponent } from './left-side/left-side.component';
import { RightSideComponent } from "./right-side/right-side.component";

@Component({
  selector: 'app-check-out-page',
  standalone: true, 
  imports: [LeftSideComponent, RightSideComponent], 
  templateUrl: './check-out-page.component.html',
  styleUrl: './check-out-page.component.css'
})
export class CheckOutPageComponent {}
