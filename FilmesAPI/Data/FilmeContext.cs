using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts)
    { 
    
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Para a entidade SessaoViewModel do Builder,
        // deverá haver uma have composta formada por FilmeId e CinemaId
        builder.Entity<SessaoViewModel>().HasKey(sessao => new { sessao.FilmeId, sessao.CinemaId });

        // Indica que para cada SessaoViewModel, um Cinema poderá
        // corresponder a muitas Sessoes
        builder.Entity<SessaoViewModel>()
            .HasOne(sessao => sessao.Cinema)
            .WithMany(cinema => cinema.Sessoes)
            .HasForeignKey(sessao => sessao.CinemaId);

        // Indica que para cada SessaoViewModel, um Filme poderá
        // corresponder a muitas Sessoes
        builder.Entity<SessaoViewModel>()
            .HasOne(sessao => sessao.Filme)
            .WithMany(filme => filme.Sessoes)
            .HasForeignKey(sessao => sessao.FilmeId);
    }

    public DbSet<FilmeViewModel> Filme { get; set; }
    public DbSet<CinemaViewModel> Cinemas { get; set; }
    public DbSet<EnderecoViewModel> Enderecos { get; set; }
    public DbSet<SessaoViewModel> Sessoes { get; set; }
}
