using System.Data.Entity;

namespace WebApplicationMVC.Models
{
    public class MeuContexto : DbContext
    {
        // Construtor
        public MeuContexto() : base("strConexao")
        {

        }

        public DbSet<Item> Itens { get; set; }
    }
}