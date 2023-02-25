import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AdminPageComponent } from './admin/admin-page/admin-page.component';
import { UserPageComponent } from './pages/user-page/user-page.component';

import { HomeComponent } from './pages/home/home.component';
import { NavbarComponent } from './shared/navbar/navbar.component';
import { TitleComponent } from './shared/title/title.component';
import { CandidatosComponent } from './components/candidatos/candidatos.component';
import { ListaCandidatosComponent } from './components/candidatos/lista-candidatos/lista-candidatos.component';
import { DetalheCandidatoComponent } from './components/candidatos/detalhe-candidato/detalhe-candidato.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AdminPageComponent,
    UserPageComponent,
    NavbarComponent,
    ListaCandidatosComponent,
    TitleComponent,
    DetalheCandidatoComponent,
    CandidatosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
