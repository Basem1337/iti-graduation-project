import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { CartItem } from '../Models/CartItem';

// export interface CartItem {
//   productId: string;
//   quantity: number;
//   title: string;
//   price: number;
//   discount: number;
//   poster: string;
//   company: string;
// }

@Injectable({
  providedIn: 'root',
})
export class CartService {
  private apiUrl = 'http://localhost:3000'; 

  constructor(private http: HttpClient) {
  }

  getCart(){
    const token = localStorage.getItem('token');
    const headers = {
      'Authorization': `Bearer ${token}`
    };
  
    return this.http.get<{_id:string,user:string,items:CartItem[]}>(`${this.apiUrl}/cart`, { headers });
  }

  addToCart(productId:string){
    const token = localStorage.getItem('token'); 

    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      Authorization: `Bearer ${token}` 
    });

    const body = { productId };

    return this.http.post(`${this.apiUrl}/cart`, body, { headers });
  }

  removeItemFromCart(productId:string){
    const token = localStorage.getItem('token'); 

    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      Authorization: `Bearer ${token}` 
    });

    const body = { productId };

    return this.http.patch<{items:CartItem[]}>(`${this.apiUrl}/cart`, body, { headers });
  }
}
