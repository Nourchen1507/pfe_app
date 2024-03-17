using ApplicationCommerciale.Core.Entities;
using ApplicationCommerciale.Core.Entities.Commande;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommercial.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
      



        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Produit> Products { get; set; }
        public virtual DbSet<Adresse> Addresses { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<ArticleCommande> ArticleCommandes { get; set; }
        public virtual DbSet<MethodeLivraison> MethodeLivraisons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
}
