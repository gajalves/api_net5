using api_net5.Domain.Entities;
using api_net5.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_net5.Infra.Context
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {
                    
        }

        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Database=apinet5;Username=postgres;Password=postgres");
            //optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=apinet5;Username=postgres;Password=postgres");
            
        }
            

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
        
    }
}
