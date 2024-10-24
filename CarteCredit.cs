using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit:Paiement
    {
        // Les propriété
        public int NumeroCarte { get; set; }

        // Le constructeur
        public CarteCredit(int carte, string description, double montant) : base(montant, description)
        {
            NumeroCarte = carte;
        }

        //La méthode Afficher
        public override void AfficherDetail()
        {
            Console.WriteLine($"Description: {Description}, Montant:{Montant}, NumeroCarte:{NumeroCarte}");
        }

    }
}
