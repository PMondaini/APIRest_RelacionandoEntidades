using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts)
    { 
    
    }

    public DbSet<FilmeViewModel> Filme { get; set; }
    public DbSet<CinemaViewModel> Cinemas { get; set; }
    public DbSet<EnderecoViewModel> Enderecos { get; set; }
}
