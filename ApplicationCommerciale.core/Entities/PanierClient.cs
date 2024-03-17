using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities
{
    public class PanierClient
    {

        public PanierClient() { }


        public PanierClient(string id) {


            Id = id;

        }

        public string Id { get; set; }
        public List<ArticlePanier> ArticlePanier { get; set; } = new List<ArticlePanier>();
        public int? IdMethodeLivraison { get; set; }
        public string SecretClient { get; set; }
        public string IdIntentionPaiement { get; set; }
        public decimal PrixLivraison { get; set; }
    }
}
