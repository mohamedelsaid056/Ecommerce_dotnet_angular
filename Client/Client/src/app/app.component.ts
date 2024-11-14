import { Product } from './../../../../../final/client/src/app/shared/models/product';
import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent implements OnInit {
  title = 'Client';
  Products: Product[] = [];
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.http
      .get<{ data: Product[] }>('https://localhost:5001/api/products')
      .subscribe({
        next: (response) => (this.Products = response.data),
        error: (error) => console.log(error),
        complete: () => console.log('complete'),
      });
  }
}
