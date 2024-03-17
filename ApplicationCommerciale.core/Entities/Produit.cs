using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities
{
    public class Produit : BaseEntity <int>
    {
        public string Nom { get; set; }
        public string Description { get; set; }

        public decimal Prix { get; set; }
        public string ImageProduit { get; set; }

        public int CategorieId { get; set; }
        public virtual Categorie Categorie { get; set; }

    }
}
    