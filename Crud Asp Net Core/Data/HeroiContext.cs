using Crud_Asp_Net_Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Asp_Net_Core.Data
{
    public class HeroiContext: DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=27101997;Persist Security Info=True;User ID=sa;Initial Catalog=HeroApp;Data Source=DESKTOP-48O40OQ\\CONEXAOSQL");
        }
    }
}
