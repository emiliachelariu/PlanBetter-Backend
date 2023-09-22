using Microsoft.EntityFrameworkCore;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Persistance.Data.Mappings
{
    internal abstract class UserMappings
    {
        internal static void Map(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(s => s.Id)
                .HasColumnName("Id")
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(s => s.FName)
                .HasColumnName("FName")
                .HasMaxLength(30);

            modelBuilder.Entity<User>()
                .Property(s => s.LName)
                .HasColumnName("LName")
                .HasMaxLength(30);

            modelBuilder.Entity<User>()
                .Property(s => s.Email)
                .HasColumnName("Email")
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                .Property(s => s.Password)
                .HasColumnName("Password")
                .HasMaxLength(50);

            modelBuilder.Entity<User>()
                  .Property(s => s.isAdmin)
                  .HasColumnName("isAdmin");
                  
        }
    }
}
