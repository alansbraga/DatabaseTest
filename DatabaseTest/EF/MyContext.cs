using DatabaseTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTest.EF;

public class MyContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseFirebird(
            "user=SYSDBA;password=masterkey;database=C:\\Tmp\\DATABASE.FDB;datasource=localhost;port=3050;dialect=3;pooling=false;servertype=0");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new InsumoMapping());
        
        //modelBuilder.UseCollation("UNICODE_CI_AI");
        
  
    }

    public DbSet<Insumo> Insumos { get; set; }
}