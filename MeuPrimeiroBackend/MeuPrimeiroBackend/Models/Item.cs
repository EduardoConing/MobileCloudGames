using System.ComponentModel.DataAnnotations;

namespace MeuPrimeiroBackend.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        [Required, StringLength(20)]
        public string Nome { get; set; }

        [Display(Name ="Descrição")]
        public string Descricao { get; set; }

        [Display(Name ="Dano Máximo")]
        public int DanoMaximo { get; set; }

        [Display(Name ="Dano Mínimo")]
        public int DanoMinimo { get; set; }

        public int Durabilidade { get; set; }

        public bool Ativo { get; set; }
    }
}