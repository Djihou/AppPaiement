using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        //Propriété
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }


        //Constructeur
        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }


        //methode afficher infos
        public void AfficherInfos()
        {
            Console.WriteLine($"Nom:{Nom}");
            foreach (Paiement p in Paiements)
            {
                p.AfficherDetail();
            }
        }
        //méthode ajouter paiements
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
    }
}
