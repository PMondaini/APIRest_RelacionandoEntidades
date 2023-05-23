using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class SessaoViewModel
    {
        public int? FilmeId { get; set; }
        public virtual FilmeViewModel Filme { get; set; }
        public int? CinemaId { get; set; }
        public virtual CinemaViewModel Cinema { get; set; }
    }
}
