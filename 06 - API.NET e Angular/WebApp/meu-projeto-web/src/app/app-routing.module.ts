import { PessoaCadastroComponent } from './pages/pessoa-cadastro/pessoa-cadastro.component';
import { PessoaListagemComponent } from './pages/pessoa-listagem/pessoa-listagem.component';
import { BarraSuperiorComponent } from './components/barra-superior/barra-superior.component';
import { MenuPrincipalComponent } from './pages/menu-principal/menu-principal.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  //{ path: 'pessoa/cadastro', component: PessoaComponent },
  { path: '', redirectTo: '/principal', pathMatch: 'full'},
  {
    path:'',
    component: BarraSuperiorComponent,
    children: [
      { path: 'principal', component: MenuPrincipalComponent},

      {
        path:'pessoa',
        children: [
          { path: 'listagem', component: PessoaListagemComponent},
          { path: 'cadastro', component: PessoaCadastroComponent},
        ]
      },
    ]
  },
  { path: '**', redirectTo: '/principal', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
