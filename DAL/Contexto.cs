using Microsoft.EntityFrameworkCore;
using P1_AP1_JamesDePeña.Models;

namespace P1_AP1_JamesDePeña.DAL;

public class Contexto : DbContext
{
    public DbSet<EntradasHuacales> Registro { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
}