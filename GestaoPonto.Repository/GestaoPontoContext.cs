using GestaoPonto.Domain.Models;
using GestaoPonto.Repository.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;

namespace GestaoPonto.Repository
{
    public class GestaoPontoContext : DbContext
    { 

        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<PointRegister> PointRegister { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Data Source=DESKTOP-PG2RQF1\SQLEXPRESS;Initial Catalog=gestaoponto;User ID=gestaouser;Password=12345678;MultipleActiveResultSets=True;",
                options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CollaboratorMap());
            modelBuilder.ApplyConfiguration(new PointRegisterMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
