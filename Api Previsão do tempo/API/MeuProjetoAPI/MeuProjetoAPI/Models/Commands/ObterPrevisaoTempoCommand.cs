using MeuProjetoAPI.Models.ViewModels;

namespace MeuProjetoAPI.Models.Commands
{
    public class ObterPrevisaoTempoCommand
    {
        public string NomeCidade { get; set; }
        public int? IdUsuario { get; set; }

    }
}
