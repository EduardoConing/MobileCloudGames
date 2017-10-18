using System.Collections.Generic;

namespace MeuPrimeiroBackend.Models
{
    public class Inventario
    {
        public int InventarioID { get; set; }

        public int JogadorID { get; set; }

        public virtual Jogador _Jogador { get; set; }

        public ICollection<Item> ItensInventario { get; set; }

    }
}