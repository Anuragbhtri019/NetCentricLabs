import { Component } from '@angular/core';

@Component({
  selector: 'app-footer',
  standalone: true,
  templateUrl: './footer.component.html',  // use your HTML file
  styleUrls: ['./footer.component.css']    // use your CSS file
})
export class FooterComponent {
  currentYear = new Date().getFullYear();
}
