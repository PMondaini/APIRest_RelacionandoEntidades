using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTO;

public class UpdateFilmeDto
{
    public string Titulo { get; set; }

    [StringLength(50, ErrorMessage = "O tamanho do Gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Range(70, 600, ErrorMessage = "A duração do filme não pode ser superior a 600 minutos")]
    public int Duracao { get; set; }

    public string Diretor { get; set; }

    public int AnoLancamento { get; set; }
}
