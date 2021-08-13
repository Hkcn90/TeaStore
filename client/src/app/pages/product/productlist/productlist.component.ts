import { Component, OnInit } from '@angular/core';
import { Products } from 'src/app/_models/Product';
import { ProductService } from 'src/app/_services/product.service';

@Component({
  selector: 'app-productlist',
  templateUrl: './productlist.component.html',
  styleUrls: ['./productlist.component.css']
})
export class ProductlistComponent implements OnInit {
Products :Products[];
  constructor(private productService:ProductService) { }

  ngOnInit(): void {
   this.getAllProducts();
  }
  getAllProducts() {
    this.productService.getAllProduct().subscribe(respose=> {
      this.Products=respose;
      console.log(respose);
    });
  }

}
