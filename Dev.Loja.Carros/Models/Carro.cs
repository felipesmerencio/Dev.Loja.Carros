using System.ComponentModel.DataAnnotations;

namespace Dev.Loja.Carros.Models
{
    public class Carro
    {
        public Guid Id { get; set; }

        [Required]
        public String Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public int Ano { get; set; }


        public string LinkImg { get; set; }

        public Carro()
        {
            Id = Guid.NewGuid();
        }
    }
}
