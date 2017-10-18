namespace MeuPrimeiroBackend.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int DanoMaximo { get; set; }

        public int DanoMinimo { get; set; }

        public int Durabilidade { get; set; }
    }
}