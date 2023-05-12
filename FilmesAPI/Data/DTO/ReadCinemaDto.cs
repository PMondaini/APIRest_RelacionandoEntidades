namespace FilmesAPI.Data.DTO;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    //4 - Busca o endereco do cinema
    public ReadEnderecoDto ReadEnderecoDto { get; set; }
}
