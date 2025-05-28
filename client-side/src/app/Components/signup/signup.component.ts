import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Component } from '@angular/core';
import { UsersService } from '../../Services/users.service';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-signup',
  imports: [ReactiveFormsModule, CommonModule, RouterModule],
  providers: [UsersService],
  templateUrl: './signup.component.html',
  styleUrl: './signup.component.css'
})
export class SignupComponent {

  myForm = new FormGroup({
    username: new FormControl(null,[Validators.pattern('^[A-Za-z]+[0-9]*$')]),
    password: new FormControl(null,[Validators.minLength(8)]),
    email: new FormControl(null,[Validators.pattern('^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$')]),
    gender: new FormControl(null,[Validators.required])
  });

  get unValid(){
    return this.myForm.controls['username'].valid;
  }

  get emValid(){
    return this.myForm.controls['email'].valid;
  }

  get passValid(){
    return this.myForm.controls['password'].valid;
  }

  get genValid(){
    return this.myForm.controls['gender'].valid;
  }

  constructor(private userService: UsersService, private router:Router){}

  errMsg:string = "";

  Add(username:string,password:string,email:string,gender:string){
    let user = {
      username:username,
      password:password,
      email:email,
      gender:gender
    };

    if (!this.genValid) {
      this.myForm.controls['gender'].markAsTouched();
      return;
    }

    if (!this.unValid) {
      this.myForm.controls['username'].markAsTouched();
      return;
    }

    if (!this.emValid) {
      this.myForm.controls['email'].markAsTouched();
      return;
    }

    if (!this.passValid) {
      this.myForm.controls['password'].markAsTouched();
      return;
    }

    if(this.myForm.valid && this.myForm.controls['username'].value && this.myForm.controls['password'].value && this.myForm.controls['email'].value && this.myForm.controls['gender'].value){
      this.userService.register(user).subscribe({
        next:res=>{
          console.log(res)
          this.router.navigate(['/login']);
        },
        error:(res)=>{
          console.log(res.error)
          this.errMsg = res.error
        }
      });
    }

  }

  passwordVisible: boolean = true;

togglePassword(){
  this.passwordVisible = !this.passwordVisible;
}

}
