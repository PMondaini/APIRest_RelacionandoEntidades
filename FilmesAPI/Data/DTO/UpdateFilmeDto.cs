using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "O Título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do Gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A Duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "A duração do filme não pode ser superior a 600 minutos")]
    public int Duracao { get; set; }

    [Required(ErrorMessage = "O Diretor do filme é obrigatório")]
    public string Diretor { get; set; }

    public int AnoLancamento { get; set; }
}
