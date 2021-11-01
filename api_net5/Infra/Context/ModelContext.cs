using api_net5.Domain.Entities;
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


        public DbSet<User> Users { get; set; }
        
    }
}
