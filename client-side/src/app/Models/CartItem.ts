export interface CartItem {
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
  
export interface UserItems {
    _id: string;
    user: string;
    items: CartItem[];
    __v: number;
  }
  