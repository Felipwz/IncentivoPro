using System;
using Microsoft.EntityFrameworkCore;
using IncentivoPro.Modelos;

namespace IncentivoPro.Modelos.Connection
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=postgres.wtdoiengvkbmptiqtdup.supabase.co;Port=5432;Username=postgres;Password=felipwz_0204;Database=postgres;Pooling=true;SslMode=Require;Trust Server Certificate=true;");
        }
    }
}
