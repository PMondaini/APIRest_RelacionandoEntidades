using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class CinemaViewModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        public int EnderecoId { get; set; }
        //1 - Indica que possui a relação com 1 endereço
        // - A propriedade virtual também serve para recuperar uma instância do objeto
        public virtual EnderecoViewModel Endereco { get; set; }
        public virtual ICollection<SessaoViewModel> Sessoes { get; set; }
    }
}
