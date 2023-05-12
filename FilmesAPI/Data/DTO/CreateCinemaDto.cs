using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O nome do cinema é obrigatório")]
    public string Nome { get; set; }
    //3 - Se torna necessário indicar o Endereço no momento da Criação do cinema
    public int EnderecoId { get; set; }
}
