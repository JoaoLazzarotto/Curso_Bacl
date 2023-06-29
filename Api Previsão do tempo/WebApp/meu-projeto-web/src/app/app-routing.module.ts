import { PrevisaoDoTempoComponent } from './pages/previsao-do-tempo/previsao-do-tempo.component';
import { PessoaCadastroComponent } from './pages/pessoa-cadastro/pessoa-cadastro.component';
import { PessoaListagemComponent } from './pages/pessoa-listagem/pessoa-listagem.component';
import { BarraSuperiorComponent } from './components/barra-superior/barra-superior.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  //{ path: 'pessoa/cadastro', component: PessoaComponent },
  { path: '', redirectTo: '/previsaodotempo', pathMatch: 'full'},
  {
    path:'',
    component: BarraSuperiorComponent,
    children: [
      { path: 'previsaodotempo', component: PrevisaoDoTempoComponent},

      {
        path:'pessoa',
        children: [
          { path: 'listagem', component: PessoaListagemComponent},
          { path: 'cadastro', component: PessoaCadastroComponent},
          { path: 'cadastro/:id', component: PessoaCadastroComponent},
        ]
      },
    ]
  },
  { path: '**', redirectTo: '/previsaodotempo', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
