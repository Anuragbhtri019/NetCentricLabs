import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { routes } from './app.routes';
import { importProvidersFrom } from '@angular/core';  // ✅ Add this line
import { FormsModule } from '@angular/forms';  // ✅ Add this line

export const appConfig: ApplicationConfig = {

  providers: [
    provideRouter(routes),
    importProvidersFrom(FormsModule)  // ✅ Add this line
  ]
};
