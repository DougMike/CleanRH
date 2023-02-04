import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminPageComponent } from './admin/admin-page/admin-page.component';
import { HomeComponent } from './pages/home/home.component';
import { UserPageComponent } from './pages/user-page/user-page.component';
import { ListaCandidatosComponent } from './shared/lista-candidatos/lista-candidatos/lista-candidatos.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent, pathMatch: 'full' },
  {
    path: '',
    loadChildren: () => import('./login/login.module').then(m => m.LoginModule)
  },
  { path: 'lista-candidatos', component: ListaCandidatosComponent },
  { path: 'adminPage', component: AdminPageComponent },
  { path: 'userPage', component: UserPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
