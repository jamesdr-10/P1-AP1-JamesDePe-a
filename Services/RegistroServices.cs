using Microsoft.EntityFrameworkCore;
using P1_AP1_JamesDePeña.DAL;
using P1_AP1_JamesDePeña.Models;
using System.Linq.Expressions;

namespace P1_AP1_JamesDePeña.Services;

public class RegistroServices(IDbContextFactory<Contexto> DbFactory)
{
    public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.Registro.Where(criterio).AsNoTracking().ToListAsync();
    }
}