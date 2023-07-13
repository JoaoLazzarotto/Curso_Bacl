import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Usuario from "../models/usuario.model";

@Injectable({
  providedIn: 'root'
})
export class WeatherService {

  private urlBase = 'http://localhost:5000/';

  constructor(
    public httpClient: HttpClient
  ) { }

  public obterPrevisaoTempo(nomeCidade: string, idUsuario: number) {
    let obterPrevisaoTempoCommand = {
      nomeCidade: nomeCidade,
      idUsuario: idUsuario
    };
    return this.httpClient.post<any>(this.urlBase + 'previsao/tempo', obterPrevisaoTempoCommand);
  }

  public obterPorId(id: number, idUsuario: number) {
    return this.httpClient.get<any>(this.urlBase + 'previsao/obterPorId/' + id + '/' + idUsuario);
  }

  public obterTodos(idUsuario: number) {
    return this.httpClient.get<any[]>(this.urlBase + 'previsao/obterTodos/' + idUsuario);
  }

  public obterCidades() {
    return this.httpClient.get<any>('assets/city.list.json');
  }

}
