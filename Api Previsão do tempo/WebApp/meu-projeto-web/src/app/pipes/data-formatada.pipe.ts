import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'dataFormatada'
})
export class DataFormatadaPipe implements PipeTransform {

  transform(data: string): string {
    const dataObj = new Date(data);
    const hora = dataObj.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit', second: '2-digit' });
    const dataFormatada = `${hora} ${dataObj.toLocaleDateString('pt-BR')}`;
    return dataFormatada;
  }
}
