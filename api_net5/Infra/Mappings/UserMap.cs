using api_net5.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_net5.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(user => user.Id);

            builder.Property(user => user.Id)
                .UseIdentityColumn()
                .HasColumnType("INT");

            builder.Property(user => user.Nome)
                .IsRequired().HasMaxLength(80).HasColumnName("nome").HasColumnType("VARCHAR(80)");

            builder.Property(user => user.Email)
                .IsRequired().HasMaxLength(180).HasColumnName("email").HasColumnType("VARCHAR(180)");

            builder.Property(user => user.Senha)
                .IsRequired().HasMaxLength(80).HasColumnName("senha").HasColumnType("VARCHAR(80)");

        }
    }
}
