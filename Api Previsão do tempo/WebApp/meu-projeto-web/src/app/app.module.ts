import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuPrincipalComponent } from './pages/menu-principal/menu-principal.component';
import { BarraSuperiorComponent } from './components/barra-superior/barra-superior.component';
import { PessoaCadastroComponent } from './pages/pessoa-cadastro/pessoa-cadastro.component';
import { CommonModule } from '@angular/common';
import {HTTP_INTERCEPTORS, HttpClientJsonpModule, HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ValidatorComponent } from './components/validator/validator.component';
import { ToastrModule } from 'ngx-toastr';
import { NgxMaskModule } from 'ngx-mask';
import { CpfPipe } from './pipes/cpf.pipe';
import { TelefonePipe } from './pipes/telefone.pipe';
import {UsuarioLogadoGuard} from "./guards/usuario-logado.guard";
import { LoginComponent } from './pages/login/login.component';
import {AuthInterceptor} from "./interceptors/requisicao.interceptor";
import {UsuarioListagemComponent} from "./pages/usuario-listagem/usuario-listagem.component";
import {UsuarioCadastroComponent} from "./pages/usuario-cadastro/usuario-cadastro.component";
import {PrevisaoDoTempoComponent} from "./pages/previsao-do-tempo/previsao-do-tempo.component";
import { DuasCasasDecimaisPipe } from './pipes/duas-casas-decimais.pipe';
import { DataFormatadaPipe } from './pipes/data-formatada.pipe';
import { PrimeiraLetraMaiusculaPipe } from './pipes/primeira-letra-maiuscula.pipe';
import { PrevisaoDoTempoListagemComponent } from './pages/previsao-do-tempo-listagem/previsao-do-tempo-listagem.component';




@NgModule({
  declarations: [
    AppComponent,
    MenuPrincipalComponent,
    BarraSuperiorComponent,
    PrevisaoDoTempoListagemComponent,
    PessoaCadastroComponent,
    UsuarioListagemComponent,
    UsuarioCadastroComponent,
    ValidatorComponent,
    PrevisaoDoTempoComponent,
    CpfPipe,
    TelefonePipe,
    LoginComponent,
    DuasCasasDecimaisPipe,
    DataFormatadaPipe,
    PrimeiraLetraMaiusculaPipe,
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    BrowserAnimationsModule,
    HttpClientModule,
    HttpClientJsonpModule,
    FormsModule,
    ReactiveFormsModule,
    ToastrModule.forRoot(),
    NgxMaskModule.forRoot(),
  ],
  providers: [
    UsuarioLogadoGuard,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

