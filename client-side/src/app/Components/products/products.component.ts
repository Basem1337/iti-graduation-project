import { Component, OnInit } from '@angular/core';
import { GameService } from '../../Services/products.service';
import { CommonModule } from '@angular/common';
import { CategoriesService } from '../../Services/categories.service';
import { RouterModule, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'] 
})
export class ProductsComponent implements OnInit {
  games: any[] = [];
  categories: any[] = [];
  filteredGames: any[] = [];
  selectedCategory: string | null = null;
  searchQuery: string = '';

  currentPage: number = 1;
  itemsPerPage: number = 12;  
  totalPages: number = 1;

  constructor(
    private productService: GameService,
    private categoryService: CategoriesService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
   
    this.route.queryParams.subscribe(params => {
      this.selectedCategory = params['category'] || null;
      this.loadGames(); 
    });

    this.loadCategories();
  }

  loadGames(): void {
    this.productService.getAllGames().subscribe((data: any) => {
      this.games = data;
      this.applyFilters();
    });
  }

  loadCategories(): void {
    this.categoryService.getCategories().subscribe((data: any) => {
      this.categories = data;
    });
  }

  filterByCategory(categoryId: string): void {
    this.selectedCategory = categoryId === 'all' ? null : categoryId;
    this.applyFilters();
  }

  filterByPrice(event: any): void {
    const priceFilter = event.target.value;
    this.applyFilters(priceFilter);
  }

  searchGames(event: any): void {
    this.searchQuery = event.target.value.toLowerCase();
    this.applyFilters();
  }

  sortGames(event: any): void {
    const sortOrder = event.target.value;
    this.filteredGames.sort((a, b) =>
      sortOrder === 'asc'
        ? a.gameName.localeCompare(b.gameName)
        : b.gameName.localeCompare(a.gameName)
    );
  }

  applyFilters(priceFilter: string = 'all'): void {
    let filtered = [...this.games];

    if (this.selectedCategory) {
      filtered = filtered.filter(game => game.category._id === this.selectedCategory);
    }

    if (this.searchQuery) {
      filtered = filtered.filter(game =>
        game.gameName.toLowerCase().includes(this.searchQuery)
      );
    }

    if (priceFilter === 'free') {
      filtered = filtered.filter(game => game.price === 0);
    } else if (priceFilter === 'cheap') {
      filtered = filtered.filter(game => game.price < 25);
    } else if (priceFilter === 'expensive') {
      filtered = filtered.filter(game => game.price >= 25);
    }

    this.filteredGames = filtered;
    this.totalPages = Math.ceil(this.filteredGames.length / this.itemsPerPage);
    this.currentPage = 1;
  }

  get paginatedGames(): any[] {
    const start = (this.currentPage - 1) * this.itemsPerPage;
    return this.filteredGames.slice(start, start + this.itemsPerPage);
  }

  changePage(page: number): void {
    if (page >= 1 && page <= this.totalPages) {
      this.currentPage = page;
    }
  }
}
