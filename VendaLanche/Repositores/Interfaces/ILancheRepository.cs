using VendaLanche.Models;
using VendaLanche.Models.LanchesMac.Models;

namespace VendaLanche.Repositores.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);

    }
}
