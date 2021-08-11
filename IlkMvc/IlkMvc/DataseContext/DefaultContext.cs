using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IlkMvc.Entities;

namespace IlkMvc.DataseContext
{
    public class DefaultContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MONSTER; Database=News; Trusted_Connection=True;");
        }

    }
}
