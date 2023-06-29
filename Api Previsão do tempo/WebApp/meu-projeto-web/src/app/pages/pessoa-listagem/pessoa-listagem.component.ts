import { AlertService } from './../../services/alert.service';
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
    public PessoaService: PessoaService,
    public alertService: AlertService
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
        this.alertService.showToastrError('Erro na requisição com o servidor');
      }
    });
  }

  public confirmarEExcluir(id: number):void{
    this.alertService.alertConfirm({
      title: 'Atenção',
      text: 'Você deseja realmente excluir o registro?',
      confirmButtonText: 'Sim',
      confirmButtonColor: "green",
      showCancelButton: true,
      cancelButtonText: 'Não',
      cancelButtonColor: "red",
      fn: () =>{
        this.chamarApiParaExcluir(id);
      },
      fnCancel: () => {

      }
    });
  }

  private chamarApiParaExcluir(id: number):void{
    this.PessoaService.excluir(id).subscribe(resposta => {

      this.alertService.showToastrSuccess('A pessoa foi excluida com sucesso!');
      this.obterPessoasDaApi();

      }
    );
  }
}
