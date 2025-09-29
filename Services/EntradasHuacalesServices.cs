using Microsoft.EntityFrameworkCore;
using P1_AP1_JamesDePeña.DAL;
using P1_AP1_JamesDePeña.Models;
using System.Linq.Expressions;

namespace P1_AP1_JamesDePeña.Services;

public class EntradasHuacalesServices(IDbContextFactory<Contexto> DbFactory)
{
    private async Task<bool> Existe(int idEntrada)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.AnyAsync(e => e.IdEntrada == idEntrada);
    }

    private async Task<bool> Insertar(EntradasHuacales entradaHuacal)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.EntradasHuacales.Add(entradaHuacal);
        return await contexto.SaveChangesAsync() > 0;
    }

    private async Task<bool> Modificar(EntradasHuacales entradaHuacal)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.EntradasHuacales.Update(entradaHuacal);
        return await contexto.SaveChangesAsync() > 0;
    }

    public async Task<bool> Guardar(EntradasHuacales entradaHuacal)
    {
        if (!await Existe(entradaHuacal.IdEntrada))
        {
            return await Insertar(entradaHuacal);
        } else
        {
            return await Modificar(entradaHuacal);
        }
    }

    public async Task<bool> Eliminar(int idEntrada)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.Where(e => e.IdEntrada == idEntrada).ExecuteDeleteAsync() > 0;
    }

    public async Task<EntradasHuacales?> Buscar(int idEntrada)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.FirstOrDefaultAsync(e => e.IdEntrada == idEntrada);
    }

    public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.Where(criterio).AsNoTracking().ToListAsync();
    }
}