using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        //Création des instances CarteCredit
        CarteCredit Carte1 = new CarteCredit(543, "Visa", 100.50);
        CarteCredit Carte2 = new CarteCredit(298, "MasterCard", 1000.0);
        CarteCredit Carte3 = new CarteCredit(960, "Amex", 100);

        // Afficher à l'écran
        Carte1.AfficherDetail();
        Carte2.AfficherDetail();
        Carte3.AfficherDetail();

        Console.WriteLine("**************************");
        //Création instnces Paypal
        Paypal paypal1 = new Paypal(100.50, "Visa", "300139241@monboreal.ca");
        Paypal paypal2 = new Paypal(1000, "Amex", "djihouah@gmail.com");
        //Afficher à l'écran
        paypal1.AfficherDetail();
        paypal2.AfficherDetail();

    }
}