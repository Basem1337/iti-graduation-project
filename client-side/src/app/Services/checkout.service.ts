import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CheckoutService {

  private apiUrl = 'http://localhost:3000'; 
  
    constructor(private http: HttpClient) {
    }

  checkout(){
    const token = localStorage.getItem('token');
    const headers = {
      'Authorization': `Bearer ${token}`
    };
  
    return this.http.post(`${this.apiUrl}/checkout`,{}, { headers });
  }
}
