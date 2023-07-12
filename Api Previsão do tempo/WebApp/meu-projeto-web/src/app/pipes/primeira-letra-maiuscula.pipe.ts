import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'primeiraLetraMaiuscula'
})
export class PrimeiraLetraMaiusculaPipe implements PipeTransform {

  transform(valor: any): any {
    if (!valor) {
      return valor;
    }

    const primeiraLetra = valor.charAt(0).toUpperCase();
    const restoString = valor.slice(1);

    return primeiraLetra + restoString;
  }
}
