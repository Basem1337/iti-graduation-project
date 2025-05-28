import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Game } from '../Models/LibraryItem';

@Injectable({
  providedIn: 'root'
})
export class LibraryService {

  private readonly dbURL = 'http://localhost:3000'

  constructor(private http:HttpClient) {}

  getLibrary(){
    const token = localStorage.getItem('token');
    const headers = {
      'Authorization': `Bearer ${token}`
    };
  
    return this.http.get<{_id:string,user:string,games:Game[]}>(`${this.dbURL}/library`, { headers });
  }
}
