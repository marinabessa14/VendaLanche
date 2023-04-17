using VendaLanche.Models;

namespace VendaLanche.Repositores.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
