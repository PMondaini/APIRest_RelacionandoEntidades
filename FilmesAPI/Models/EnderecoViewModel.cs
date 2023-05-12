using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class EnderecoViewModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        //2 - Insere a referência do cinema no Endereco
        public virtual CinemaViewModel Cinema { get; set; }
    }
}
