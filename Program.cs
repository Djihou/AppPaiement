using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        //Instance Utilisateur
        Utilisateur utilisateur = new Utilisateur("Hertz Sully DJIHOUA");

        //Création des instances CarteCredit
        CarteCredit Carte1 = new CarteCredit(543, "Visa", 100.50);
        CarteCredit Carte2 = new CarteCredit(298, "MasterCard", 1000.0);
        CarteCredit Carte3 = new CarteCredit(960, "Amex", 100);
        /*
        // Afficher à l'écran
        Carte1.AfficherDetail();
        Carte2.AfficherDetail();
        Carte3.AfficherDetail();*/

        
        //Création instnces Paypal
        Paypal paypal1 = new Paypal(100.50, "Visa", "300139241@monboreal.ca");
        Paypal paypal2 = new Paypal(1000, "Amex", "djihouah@gmail.com");
        /* //Afficher à l'écran
         paypal1.AfficherDetail();
         paypal2.AfficherDetail();*/

        //Ajout des objets CarteCredit et Paypal à mon Utilisateur
        utilisateur.AjouterPaiement(Carte1);
        utilisateur.AjouterPaiement(Carte2);
        utilisateur.AjouterPaiement(Carte3);
        utilisateur.AjouterPaiement(paypal1);
        utilisateur.AjouterPaiement(paypal2);

        Console.WriteLine("**********************************************************");
        Console.WriteLine($"*Liste des paiements de l'utilisateur {utilisateur.Nom}*");
        Console.WriteLine("**********************************************************");
        Console.WriteLine("    ");
        Console.WriteLine("    ");
        //Affichage de la liste des paiements de cet utilisateur.
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("           Paiements par carte de crédit: ");
        Console.WriteLine("-----------------------------------------------------");
        foreach (Paiement p in utilisateur.Paiements)
        {
            if (p is CarteCredit carte)
            {
                carte.AfficherDetail();
            }
        }
        Console.WriteLine("    ");
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("            Paiements par paypal: ");
        Console.WriteLine("-----------------------------------------------------");
        foreach(Paiement p in utilisateur.Paiements )
        {
            if(p is Paypal paypal)
            {
                paypal.AfficherDetail();
            }
        }

    }
}