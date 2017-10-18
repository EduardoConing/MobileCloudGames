using System.ComponentModel.DataAnnotations;

namespace MeuPrimeiroBackend.Models
{
    public class Jogador
    {
        [Key]
        public int JogadorID { get; set; }

        public string Nickname { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

    }
}