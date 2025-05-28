import { Component } from '@angular/core';
import { UsersService } from '../../Services/users.service';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-login',
  imports: [ReactiveFormsModule, CommonModule, RouterModule],
  // providers:[UsersService],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  myForm = new FormGroup({
      email: new FormControl(null,[Validators.pattern('^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$')]),
      password: new FormControl(null,[Validators.minLength(8)]),
    });

constructor(private usersService:UsersService,private Router :Router){}

get emValid(){
  return this.myForm.controls['email'].valid;
}

get passValid(){
  return this.myForm.controls['password'].valid;
}

errMsg = ""; 

onSubmit(email:string,password:string){
  if(this.myForm.valid && this.myForm.controls['password'].value && this.myForm.controls['email'].value){
    this.usersService.login({email,password}).subscribe({
      next:res=>{
        localStorage.setItem("token","Bearer "+res)
        // this.Router.navigate(["/home"])
        window.location.href = "/home"
      },
      error:res=>{
        console.log(res.error)
        this.errMsg = res.error;
      },
    })
  }
}

passwordVisible: boolean = true;

togglePassword(){
  this.passwordVisible = !this.passwordVisible;
}

}
