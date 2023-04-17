using LanchesMac.Models;
using VendaLanche.Models.LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
