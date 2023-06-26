import { PessoaService } from './../../services/pessoa.service';
import { Component, OnInit } from '@angular/core';
import Pessoa from 'src/app/models/pessoa.model';

@Component({
  selector: 'app-pessoa-listagem',
  templateUrl: './pessoa-listagem.component.html',
  styleUrls: ['./pessoa-listagem.component.css']
})
export class PessoaListagemComponent implements OnInit {

  public listaPessoas: Pessoa[] = [];

  constructor(
    public PessoaService: PessoaService
  ) { }

  ngOnInit(): void {
    document.title = 'Listagem de pessoas'

    this.obterPessoasDaApi();
  }
  public obterPessoasDaApi():void {
    this.PessoaService.obterTodos().subscribe(resposta => {
      //subscribe é oque o service tem que fazer quando tiver o retorno da resposta

      if(resposta != null){
        this.listaPessoas = resposta;
      } else{
        alert('Erro na requisição com o servidor');
      }

    });
  }

  public excluir(id: number):void{
    this.PessoaService.excluir(id).subscribe(resposta => {

      alert('A pessoa foi excluida com sucesso!');
      this.obterPessoasDaApi();

      }
    );
  }
}
