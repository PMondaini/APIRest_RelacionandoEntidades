using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O ampo nome é obrigatório")]
    public string Nome { get; set; }
}
