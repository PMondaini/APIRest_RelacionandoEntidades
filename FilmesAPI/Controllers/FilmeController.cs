using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTO;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
    {
        FilmeViewModel filme = _mapper.Map<FilmeViewModel>(filmeDto);
        _context.Filme.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaFilme), new { id = filme.Id }, filmeDto);
    }

    [HttpGet]
    public IEnumerable<FilmeViewModel> RecuperaFilme([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return _context.Filme.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilme(int id)
    {
        var filme = _context.Filme.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        return Ok(filme);

    }

    //Alterando algum filme salvo
    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filme.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();

        return NoContent();
    }
}
 