import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { AdminPageComponent } from './admin/admin-page/admin-page.component';
import { UserPageComponent } from './pages/user-page/user-page.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { ListaCandidatosComponent } from './components/lista-candidatos/lista-candidatos.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AdminPageComponent,
    UserPageComponent,
    NavbarComponent,
    ListaCandidatosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
