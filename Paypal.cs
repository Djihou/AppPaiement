using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal: Paiement
    {
        //propriété
        public string Courriel { get; set; }

        //constructeur
        public Paypal(double montant, string description, string email) : base(montant, description)
        {
            Courriel = email;
        }

        //methode afficher
        public override void AfficherDetail()
        {
            Console.WriteLine($"Montant:{Montant}, Description:{Description}, Courriel: {Courriel}");
        }
    }
}
