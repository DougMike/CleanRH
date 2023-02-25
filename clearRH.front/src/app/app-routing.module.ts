import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminPageComponent } from './admin/admin-page/admin-page.component';
import { CandidatosComponent } from './components/candidatos/candidatos.component';
import { DetalheCandidatoComponent } from './components/candidatos/detalhe-candidato/detalhe-candidato.component';
import { ListaCandidatosComponent } from './components/candidatos/lista-candidatos/lista-candidatos.component';
import { HomeComponent } from './pages/home/home.component';
import { UserPageComponent } from './pages/user-page/user-page.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  {
    path: 'candidatos', component: CandidatosComponent
    , children: [
      { path: '', redirectTo: 'lista-candidatos', pathMatch: 'full' },
      { path: 'lista-candidatos', component: ListaCandidatosComponent },
      { path: 'detalhe-candidato/:id', component: DetalheCandidatoComponent }
    ]
  },
  { path: 'adminPage', component: AdminPageComponent },
  { path: 'userPage', component: UserPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
