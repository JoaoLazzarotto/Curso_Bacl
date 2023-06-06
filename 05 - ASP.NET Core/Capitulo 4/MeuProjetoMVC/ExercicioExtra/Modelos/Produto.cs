using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExtra.Modelos
{  
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime? DataValidade { get; set; }

        public decimal? PrecoCompra { get; set; }

        public decimal PrecoVenda { get; set; }


        public decimal QuantidadeEstoque { get; set; }


        public string EstaValidoParaSalvar()
        {
            var validacoes = new StringBuilder();

            // validando campo nome
            if (string.IsNullOrEmpty(Nome))
            {
                validacoes.Append("O campo nome é obrigatório");
            }
            else if (Nome.Length > 200)
            {
                validacoes.Append("O campo nome deve ter no máximo 200 caracteres");
            }
            // validando campo PrecoVenda
            if (PrecoVenda <= 0)
            {
                validacoes.Append("O campo Preço de Venda é obrigatório");
            }
            // validando campo Email
            if (QuantidadeEstoque <= 0)
            {
                validacoes.Append("A Quantidade de Estoque é obrigatório");
            }

            return validacoes.ToString();
        }

    }

}
