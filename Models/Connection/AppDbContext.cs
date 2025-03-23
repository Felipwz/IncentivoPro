using System;
using Microsoft.EntityFrameworkCore;
using IncentivoPro.Models.Tables;
using Microsoft.Extensions.Configuration;

namespace IncentivoPro.Models.Connection
{

    public class AppDbContext : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Admin> Admins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseNpgsql("User Id=postgres.wtdoiengvkbmptiqtdup;Password=felipwz_0204;Server=aws-0-sa-east-1.pooler.supabase.com;Port=5432;Database=postgres");



            }

   



      
    }
}
