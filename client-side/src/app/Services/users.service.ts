import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class UsersService {

  private readonly dbURL = 'http://localhost:3000'

  constructor(private http:HttpClient) { }

  register(user:any){
    return this.http.post(this.dbURL+"/users/register",user);
  }

  login(user:any){
    return this.http.post(this.dbURL+"/users/login",user);
  }

  getUser(){
    const token = localStorage.getItem('token');
    const headers = {
      'Authorization': `Bearer ${token}`
    };
  
    return this.http.get<{username:string,email:string}>(`${this.dbURL}/users/me`, { headers });
  }

  addToCart(userId: string, gameId: string): Observable<any> {
    return this.http.post(`${this.dbURL}/${userId}/cart`, { gameId });
  }

  addToWishlist(userId: string, gameId: string): Observable<any> {
    return this.http.post(`${this.dbURL}/${userId}/wishlist`, { gameId });
  }

  getCart(userId: string): Observable<any> {
    return this.http.get(`${this.dbURL}/${userId}/cart`);
  }

  getWishlist(userId: string): Observable<any> {
    return this.http.get(`${this.dbURL}/${userId}/wishlist`);
  }
  
}
