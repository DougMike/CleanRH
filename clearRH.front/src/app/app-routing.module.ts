import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminPageComponent } from './admin/admin-page/admin-page.component';
import { HomeComponent } from './pages/home/home.component';
import { UserPageComponent } from './pages/user-page/user-page.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'adminPage', component: AdminPageComponent },
  { path: 'userPage', component: UserPageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }
