using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities.Commande
{
    public  class Commande : BaseEntity <int>
    {

        public Commande() { }
        //testpush
        public Commande (string emailAcheteur, DateTime dateCommande, AdresseLivraison addresseLivraison, MethodeLivraison methodeLivraison, IReadOnlyList<ArticleCommande> articleCommandes, decimal soustotal, StatutCommande statutCommande, string idPaiement)
        {
            EmailAcheteur = emailAcheteur;
            DateCommande = dateCommande;
            AddresseLivraison = addresseLivraison;
            MethodeLivraison = methodeLivraison;
            ArticleCommandes = articleCommandes;
            Soustotal = soustotal;
            StatutCommande = statutCommande;
            IdPaiement = idPaiement;
        }

        public string EmailAcheteur { get; set; }
        public DateTime DateCommande { get; set; } = DateTime.Now;
        public AdresseLivraison AddresseLivraison{ get; set; }
        public MethodeLivraison MethodeLivraison { get; set; }
        public IReadOnlyList<ArticleCommande> ArticleCommandes { get; set; }
        public decimal Soustotal { get; set; }
        public StatutCommande StatutCommande { get; set; } = StatutCommande.EnAttente;

        public string IdPaiement { get; set; }

        public decimal GetTotal()
        {
            return Soustotal + MethodeLivraison.Prix;
        }

    }
}