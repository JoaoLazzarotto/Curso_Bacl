import { AutenticacaoService } from './../../services/autenticacao.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AlertService } from 'src/app/services/alert.service';
import { WeatherService } from 'src/app/services/weather.service';

@Component({
  selector: 'app-previsao-do-tempo',
  templateUrl: './previsao-do-tempo.component.html',
  styleUrls: ['./previsao-do-tempo.component.css'],
})
export class PrevisaoDoTempoComponent implements OnInit, OnDestroy {
  public formulario: FormGroup;
  public formSubmetido: boolean = false;

  public buscaPrevisao: any = null;

  public id: number = null;

  constructor(
    public formBuilder: FormBuilder,
    public router: Router,
    public activatedRoute: ActivatedRoute,
    public weatherService: WeatherService,
    public alertService: AlertService,
    public autenticacaoService: AutenticacaoService
  ) {}

  // METODOS
  public ngOnInit(): void {
    this.id = this.activatedRoute.snapshot.params['id'];

    if(this.id == null) {
      document.title = 'Nova previsão do tempo';
    } else {
      document.title = 'Visualizar previsão do tempo';
      this.chamarApiParaHistoricoPorId(this.id);
    }

    this.inicializarForm();
  }

  public ngOnDestroy(): void {}


  private inicializarForm(): void {
    this.formulario = this.formBuilder.group({
      nomeCidade: [null, [Validators.required]],
    });
  }

  public submeterForm(): void {
    this.formSubmetido = true;

    if (this.formulario.invalid) {
      return;
    }

    let objForm = this.formulario.getRawValue();

    const idUsuario = this.autenticacaoService.obterIdUsuario();
    this.chamarApiParaObterPrevisaoDoTempo(objForm.nomeCidade, idUsuario);
  }

  public chamarApiParaObterPrevisaoDoTempo(nomeCidade: string, idUsuario: number): void {
    this.alertService.showToastrInfo(
      'Buscando previsão do tempo para a cidade de ' + nomeCidade
    );

    this.weatherService.obterPrevisaoTempo(nomeCidade, idUsuario).subscribe(
      (resposta) => {
        if (resposta != null) {
          this.alertService.showToastrSuccess(
            'Previsão encontrada com sucesso'
          );
          this.buscaPrevisao = resposta;
        } else {
          this.alertService.showToastrError('Erro ao buscar previsão');
        }
      },
      (exception) => {
        let mensagemErro =
          typeof exception?.error === 'string' ? exception?.error : '';
        this.alertService.showToastrError(
          'Erro ao conectar com o servidor',
          mensagemErro
        );
      }
    );
  }

  public chamarApiParaHistoricoPorId(id: number): void {
    const idUsuario = this.autenticacaoService.obterIdUsuario();

    this.weatherService.obterPorId(id, idUsuario).subscribe(resposta => {

      if(resposta != null) {
        this.buscaPrevisao = resposta;
      }

    }, exception => {
      let mensagemErro = exception?.error instanceof String ? exception?.error : '';
      this.alertService.showToastrError('Erro ao conectar com o servidor', mensagemErro);
    });
  }
}
