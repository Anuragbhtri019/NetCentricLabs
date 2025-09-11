import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';   // ✅ Needed for *ngIf
import { FormsModule } from '@angular/forms';     // ✅ Needed for [(ngModel)]


@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.html',
  styleUrls: ['./calculator.css'],
  standalone: true,
  imports: [CommonModule, FormsModule]
})
export class CalculatorComponent {
  num1: number = 0;
  num2: number = 0;
  operation: string = 'add';
  result: number | null = null;

  compute() {
    switch (this.operation) {
      case 'add':
        this.result = this.num1 + this.num2;
        break;
      case 'subtract':
        this.result = this.num1 - this.num2;
        break;
      case 'multiply':
        this.result = this.num1 * this.num2;
        break;
      default:
        this.result = null;
    }
  }
}
