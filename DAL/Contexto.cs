using Microsoft.EntityFrameworkCore;
using P1_AP1_JamesDePeña.Models;

namespace P1_AP1_JamesDePeña.DAL;

public class Contexto : DbContext
{
    public DbSet<EntradasHuacales> EntradasHuacales { get; set; }
    public DbSet<EntradasHuacalesDetalle> EntradasHuacalesDetalle { get; set; }
    public DbSet<TiposHuacales> TiposHuacales { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TiposHuacales>().HasData(
            new TiposHuacales { TipoId = 1, Descripcion = "Huacal Rojo", Existencia = 50 },
            new TiposHuacales { TipoId = 2, Descripcion = "Huacal Verde", Existencia = 10 }
            );
    }
}