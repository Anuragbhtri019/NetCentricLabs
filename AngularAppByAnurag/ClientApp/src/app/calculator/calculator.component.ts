import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css'],
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
