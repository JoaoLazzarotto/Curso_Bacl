using MeuProjetoApi.BancoDados.Contexto;
using MeuProjetoApi.Models;
using MeuProjetoAPI.Models;

namespace MeuProjetoAPI.BancoDados.Repositorios
{
    public class HistoricoPrevisaoTempoRepositorio
    { 
        public PrevisaoTempo ObterPorId(int id, int idUsuario)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var previsaoTempoHistorico = bancoDeDados.TabelaPrevisoesDoTempoHistoricos
                    .Where(p => p.Id == id)
                    .Where(x => x.IdUsuario == idUsuario)
                    .FirstOrDefault();

                return previsaoTempoHistorico;
            }
        }

        public List<PrevisaoTempo> ObterTodos(int idUsuario)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var listaprevisaoTempoHistorico = bancoDeDados.TabelaPrevisoesDoTempoHistoricos
                    .Where(p => p.IdUsuario == idUsuario)
                    .ToList();
                return listaprevisaoTempoHistorico;
            }
        }

        public PrevisaoTempo Adicionar(PrevisaoTempo previsaoTempo)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                bancoDeDados.TabelaPrevisoesDoTempoHistoricos.Add(previsaoTempo);
                bancoDeDados.SaveChanges();
            }

            return previsaoTempo;
        }
    }
}
