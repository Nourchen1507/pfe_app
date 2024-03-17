using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCommerciale.Core.Entities.Commande
{
    public enum StatutCommande
    {

        [EnumMember(Value = "EnAttente")]

        EnAttente,

        [EnumMember(Value = "Paiement Recu")]

        PaiementRecu,

        [EnumMember(Value = "Paiement Echoue")]

        PaiementEchoue,
            

    }

}