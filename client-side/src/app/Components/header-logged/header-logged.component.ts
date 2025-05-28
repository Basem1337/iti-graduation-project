import { Component, OnInit } from '@angular/core';
import { UsersService } from '../../Services/users.service';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-header-logged',
  imports: [CommonModule,RouterModule],
  templateUrl: './header-logged.component.html',
  styleUrl: './header-logged.component.css'
})
export class HeaderLoggedComponent {

  userName:string = "";
  errMsg: string = "";

  constructor(private usersService:UsersService,private Router :Router){}

  ngOnInit(): void {
    this.usersService.getUser().subscribe({
      next: (res) => {
        console.log('User:', res); 
        this.userName = res.username;
      },
      error: (err) => {
        console.error(err);
        this.errMsg = err.error;
      }
    });
  }

  // getUserName(){
  //   this.usersService.getUser({}).subscribe({
  //     next:res=>{
  //       localStorage.setItem("token","Bearer "+res)
  //       // this.Router.navigate(["/home"])
  //     },
  //     error:res=>{
  //       console.log(res.error)
  //       this.errMsg = res.error;
  //     },
  //   })
  // }


  
  
}
