using System.Collections.Generic;

namespace MeuPrimeiroBackend.Models
{
    public class Inventario
    {
        public int InventarioID { get; set; }

        // chave para achar o jogador no banco
        public int JogadorID { get; set; }

        // Lazy Load - para carregar o jogador sem Null Reference Exception
        public virtual Jogador _Jogador { get; set; }

        public ICollection<Item> ItensInventario { get; set; }

    }
}