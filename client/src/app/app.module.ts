import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './nav/sidebar/sidebar/sidebar.component';
import { ToolbarComponent } from './nav/toolbar/toolbar/toolbar.component';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { RouterModule, Routes } from '@angular/router';
import { DasboardComponent } from './dasboard/dasboard.component';
import { FormsModule } from '@angular/forms';
import { EmployeelistComponent } from './pages/employee/employeelist/employeelist.component';
import { EmployeedetailsComponent } from './pages/employee/employeedetails/employeedetails.component';
import { EmployeeaddComponent } from './pages/employee/employeeadd/employeeadd.component';
import { ProductaddComponent } from './pages/product/productadd/productadd.component';
import { ProductdetailsComponent } from './pages/product/productdetails/productdetails.component';
import { ProductlistComponent } from './pages/product/productlist/productlist.component';


const appRoutes: Routes = [
  {
    path: 'home', component: HomeComponent, 
    children: [
      { path: 'dashboard', component: DasboardComponent },
      { path: 'employeelist', component: EmployeelistComponent },
      { path: 'employeedetails', component: EmployeedetailsComponent },
      { path: 'employeeadd', component: EmployeeaddComponent },

      { path: 'productlist', component: ProductlistComponent },
      { path: 'productdetails', component: ProductdetailsComponent },
      { path: 'productadd', component: ProductaddComponent },

    ]
  },
   { path: 'login', component: LoginComponent },
   { path: '**', redirectTo: '/login', pathMatch: 'full' }
];

@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    ToolbarComponent,
    LoginComponent,
    HomeComponent,
    DasboardComponent,
    EmployeelistComponent,
    EmployeedetailsComponent,
    EmployeeaddComponent,
    ProductaddComponent,
    ProductdetailsComponent,
    ProductlistComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
