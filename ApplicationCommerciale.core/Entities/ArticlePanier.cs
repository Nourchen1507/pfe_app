using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities
{
    public class ArticlePanier
    {

        public int Id { get; set; }
        
        public string NomProduit {  get; set; }
        public string ImageProduit { get; set; }

        public decimal Prix { get; set; }
        public string Categorie { get; set; }



    }
}
