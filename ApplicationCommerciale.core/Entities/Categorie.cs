using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities
{
    public class Categorie : BaseEntity<int>
    {
        public string Nom { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Produit> Produits { get; set; } = new HashSet<Produit>();
    }
}
