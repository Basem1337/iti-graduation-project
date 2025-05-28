import { Component } from '@angular/core';
import { LeftSideComponent } from './left-side/left-side.component';
import { RightSideComponent } from './right-side/right-side.component';

@Component({
  selector: 'app-profile',
  imports: [LeftSideComponent,RightSideComponent],
  templateUrl: './profile.component.html',
  styleUrl: './profile.component.css'
})
export class ProfileComponent {

}
