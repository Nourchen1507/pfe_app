using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities.Commande
{
    public class ArticleCommande
    {
        public ArticleCommande() { }

        public ArticleCommande(ProduitArticleCommande produitArticleCommande, decimal prix, int quantite)
        {
            ProduitArticleCommande = produitArticleCommande;
            Prix = prix;
            Quantite = quantite;
        }

        public ProduitArticleCommande ProduitArticleCommande { get; set; }
        public decimal Prix { get; set; }

        public int Quantite {  get; set; }

    }
}
