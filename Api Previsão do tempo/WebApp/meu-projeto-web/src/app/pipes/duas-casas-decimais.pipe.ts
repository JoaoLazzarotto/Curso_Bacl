import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'duasCasasDecimais'
})
export class DuasCasasDecimaisPipe implements PipeTransform {

  transform(numero: number): string {
    const duasCasasDecimais = numero.toLocaleString('pt-BR', {
      minimumFractionDigits: 2,
      maximumFractionDigits: 2,
    });
    return duasCasasDecimais;
  }
}
