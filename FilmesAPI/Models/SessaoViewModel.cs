using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class SessaoViewModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int FilmeId { get; set; }
        public virtual FilmeViewModel Filme { get; set; }

    }
}
