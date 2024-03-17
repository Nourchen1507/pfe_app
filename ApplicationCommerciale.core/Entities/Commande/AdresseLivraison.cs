using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities.Commande
{
    public class AdresseLivraison
    {
        public AdresseLivraison() { }

        public  AdresseLivraison(string nom , string prenom , string rue, string ville, string etat, string codepostal)
        {

            Nom = nom;
            Prenom = prenom;
            Rue = rue;
            Ville = ville;
            Etat = etat;
            CodePostal = codepostal;
        }



        public string Nom {  get; set; }
        public string Prenom  { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }

        public string Etat { get; set; }
        public string CodePostal { get; set; }

    }
}
