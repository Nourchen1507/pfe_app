using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities.Commande
{
    public class ProduitArticleCommande
    {

        public ProduitArticleCommande() { }

        public ProduitArticleCommande(int id, string produitArticleNom, string urlImage)
        {
            Id = id;
            ProduitArticleNom = produitArticleNom;
            UrlImage = urlImage;
        }

        public int Id { get; set; }
        public string ProduitArticleNom { get; set; }

        public string UrlImage { get; set; }

    }
}
