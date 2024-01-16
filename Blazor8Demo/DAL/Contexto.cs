using Blazor8Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor8Demo.DAL;

public class Contexto: DbContext
{
    public DbSet<Prioridades> Prioridades { get; set; }

    public Contexto(DbContextOptions<Contexto> options): base(options)
    {
        
    }
}
