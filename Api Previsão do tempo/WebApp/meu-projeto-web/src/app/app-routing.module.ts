import { PrevisaoDoTempoListagemComponent } from './pages/previsao-do-tempo-listagem/previsao-do-tempo-listagem.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MenuPrincipalComponent } from './pages/menu-principal/menu-principal.component';
import { BarraSuperiorComponent } from './components/barra-superior/barra-superior.component';
import {UsuarioLogadoGuard} from "./guards/usuario-logado.guard";
import {LoginComponent} from "./pages/login/login.component";
import {UsuarioListagemComponent} from "./pages/usuario-listagem/usuario-listagem.component";
import {UsuarioCadastroComponent} from "./pages/usuario-cadastro/usuario-cadastro.component";
import { PrevisaoDoTempoComponent } from './pages/previsao-do-tempo/previsao-do-tempo.component';

const routes: Routes = [
  { path: '', redirectTo: '/principal', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  {
    path: '',
    canActivate: [UsuarioLogadoGuard],
    component: BarraSuperiorComponent,
    children: [
      { path: 'principal', component: MenuPrincipalComponent },
      {
        path: 'previsao',
        children: [
          { path: 'listagem', component: PrevisaoDoTempoListagemComponent },
          { path: 'tempo', component: PrevisaoDoTempoComponent },
          { path: 'tempo/:id', component: PrevisaoDoTempoComponent },
        ]
      },
      {
        path: 'usuario',
        children: [
          { path: 'listagem', component: UsuarioListagemComponent },
          { path: 'cadastro', component: UsuarioCadastroComponent },
          { path: 'cadastro/:id', component: UsuarioCadastroComponent },
        ]
      },
    ]
  },
  { path: '**', redirectTo: '/principal', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
