using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O nome do cinema é obrigatório")]
    public string Nome { get; set; }
}
