using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities
{
    public  class Adresse
    {

        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }

        public string Rue { get; set; }
        public string Ville { get; set; }

        public string Etat { get; set; }

        public string CodePostal { get; set; }

        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }

}

