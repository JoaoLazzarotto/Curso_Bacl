import { Component, OnDestroy, OnInit } from '@angular/core';

@Component({
  selector: 'app-previsao-do-tempo',
  templateUrl: './previsao-do-tempo.component.html',
  styleUrls: ['./previsao-do-tempo.component.css']
})
export class PrevisaoDoTempoComponent implements OnInit, OnDestroy {


  weatherForecasts = [
    { date: '29/06/2023', temperature: '25°C', condition: 'Ensolarado' },
    { date: '30/06/2023', temperature: '22°C', condition: 'Parcialmente nublado' },
    { date: '01/07/2023', temperature: '18°C', condition: 'Chuvoso' }
  ];

// METODOS
  public ngOnInit(): void {}

  public ngOnDestroy(): void {}

}
