import { AutenticacaoService } from './../../services/autenticacao.service';
import { WeatherService } from 'src/app/services/weather.service';
import { Component, OnInit } from '@angular/core';
import { AlertService } from 'src/app/services/alert.service';

@Component({
  selector: 'app-previsao-do-tempo-listagem',
  templateUrl: './previsao-do-tempo-listagem.component.html',
  styleUrls: ['./previsao-do-tempo-listagem.component.css']
})
export class PrevisaoDoTempoListagemComponent implements OnInit {

  public listaPrevisoes: any[] = [];

  constructor(
    public weatherService: WeatherService,
    public autenticacaoService: AutenticacaoService,
    public alertService: AlertService
  ) { }

  public ngOnInit(): void {
    document.title = 'Histórico de previsões';

    this.obterHistoricoPrevisoesDaApi();
  }

  public obterHistoricoPrevisoesDaApi(): void {
    const idUsuario = this.autenticacaoService.obterIdUsuario();
    this.weatherService.obterTodos(idUsuario).subscribe(resposta => {

      if(resposta != null) {
        this.listaPrevisoes = resposta;
      } else {
        this.alertService.showToastrError('Erro na requisição com o servidor');
      }

    }, exception => {
      let mensagemErro = exception?.error instanceof String ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }

}
