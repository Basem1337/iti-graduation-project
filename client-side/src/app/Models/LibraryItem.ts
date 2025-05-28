export interface Game {
    _id: string;
    gamePoster: string;
    gameName: string;
    company: string;
    category: string;
    description: string;
    price: number;
    originalPrice: number;
    rating: number;
    trailer: string;
    releaseYear: number;
    discount: number;
    __v: number;
  }
  
  interface UserGames {
    _id: string;
    user: string;
    games: Game[];
    __v: number;
  }