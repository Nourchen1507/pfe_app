using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities.Commande
{
    public class MethodeLivraison : BaseEntity <int>
    {

        public string NomCourt { get; set; }
        public string TempsLivraison { get; set; }
        public string Description  {   get; set; }

        public decimal Prix { get; set; }




    }
}
