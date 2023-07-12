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

  constructor(
    public formBuilder: FormBuilder,
    public router: Router,
    public activatedRoute: ActivatedRoute,
    public weatherService: WeatherService,
    public alertService: AlertService
  ) {}

  // METODOS
  public ngOnInit(): void {
    document.title = 'Previsão do tempo';

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

    this.chamarApiParaObterPrevisaoDoTempo(objForm.nomeCidade);
  }

  public chamarApiParaObterPrevisaoDoTempo(nomeCidade: string): void {
    this.alertService.showToastrInfo(
      'Buscando previsão do tempo para a cidade de ' + nomeCidade
    );

    this.weatherService.obterPrevisaoTempo(nomeCidade).subscribe(
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
}
