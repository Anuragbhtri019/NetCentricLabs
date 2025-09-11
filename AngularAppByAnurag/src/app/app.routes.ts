import { Routes } from '@angular/router';
import { HomeComponent } from './home/home';              // ✅ correct path
import { CalculatorComponent } from './calculator/calculator';  // ✅ correct path

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'calculator', component: CalculatorComponent },
  { path: '**', redirectTo: 'home' }
];
