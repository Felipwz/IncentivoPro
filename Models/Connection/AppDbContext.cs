using System;
using Microsoft.EntityFrameworkCore;
using IncentivoPro.Modelos.Tables;
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

        //public DbSet<Aluno> Alunos { get; set; }

        //private IConfiguration _configuration;

        //public AppDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        //{
        //    _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var typeDataBase = _configuration["TypeDataBase"];
        //    var connectionString = _configuration.GetConnectionString(typeDataBase);

        //    if (typeDataBase == "Postgresql")
        //    {

        //        optionsBuilder.UseNpgsql(connectionString);

        //    }

        //}



      
    }
}
