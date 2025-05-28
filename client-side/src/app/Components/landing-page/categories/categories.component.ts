import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { GameService } from '../../../Services/products.service';
import { CategoriesService } from '../../../Services/categories.service';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-categories',
  imports: [CommonModule ,RouterModule],
  templateUrl: './categories.component.html',
  styleUrl: './categories.component.css'
})
export class CategoriesComponent {
  categories: any[] = [];
  constructor(private categoryService: CategoriesService) {}
  
  
  ngOnInit(): void {
    this.loadCategories();
  }

  loadCategories(): void {
    this.categoryService.getCategories().subscribe((data: any) => {
      this.categories = data;
    });
  }
}
