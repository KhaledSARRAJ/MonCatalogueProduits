using Microsoft.EntityFrameworkCore; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonCatalogueProduit.Service
{
    public class CatalogueDbContext: DbContext
    {
        public DbSet<Demande> Produits { set; get; }
        public DbSet<Categorie> Categories { set; get; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Nom de serveur + Nom de base de donneer + 
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=Pandami;Trusted_Connection=True");
        }
    }
}
