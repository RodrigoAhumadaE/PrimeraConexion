#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;

namespace PrimeraConexion.Models;

public class MyContext : DbContext{
    public MyContext(DbContextOptions options) : base(options){}

    public DbSet<Mascota> Mascotas { get; set; }
}