using System.Data.Entity;

namespace MeuPrimeiroBackend.Models.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base("strConn")
        {

        }

        public System.Data.Entity.DbSet<MeuPrimeiroBackend.Models.Item> Items { get; set; }

        public System.Data.Entity.DbSet<MeuPrimeiroBackend.Models.Jogador> Jogadores { get; set; }

        public System.Data.Entity.DbSet<MeuPrimeiroBackend.Models.Inventario> Inventarios { get; set; }
    }
}