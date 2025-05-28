
// game.service.ts
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Game {
  id: string;
  _id: string;
  gameName: string;
  gamePoster:string;
  company:string;
  category: { _id: string; name: string };
  description: string;
  price:number;
  originalPrice:number;
  rating: number;
  tags: string[];
  trailer: string;
  releaseYear:number;
  discount:number;
  
}

@Injectable({
  providedIn: 'root'
})
export class GameService {
  private apiUrl = 'http://localhost:3000/products'; 

  constructor(private http: HttpClient) { }

  getAllGames(): Observable<Game[]> {
    return this.http.get<Game[]>(`${this.apiUrl}/games`);
  }

  getGameById(id: number): Observable<Game> {
    return this.http.get<Game>(`${this.apiUrl}/games/${id}`);
  }
}
