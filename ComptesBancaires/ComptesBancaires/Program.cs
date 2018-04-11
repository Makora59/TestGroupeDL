using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesBancaires
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des instances utilisées dans le main
            CompteCourant compteNicolas = new CompteCourant(2000)
            {
                Proprietaire = "Nicolas",
            };

            CompteEpargneEntreprise compteEpargneNicolas = new CompteEpargneEntreprise(0.02)
            {
                Proprietaire = "Nicolas",
            };

            CompteCourant compteJeremie = new CompteCourant(500)
            {
                Proprietaire = "Jeremie",
            };

            // Effectue les opérations sur les instances
            compteNicolas.Crediter(100);
            compteNicolas.Debiter(50);

            compteEpargneNicolas.Crediter(20, compteNicolas);
            compteEpargneNicolas.Crediter(100);
            compteEpargneNicolas.Debiter(20, compteNicolas);

            compteJeremie.Debiter(500);
            compteJeremie.Debiter(200, compteNicolas);

            // Affiche les informations des instances dans la console
            Console.WriteLine("Résumé du compte de Nicolas");
            Console.WriteLine("**************************************************************");
            compteNicolas.AfficheResume();
            Console.WriteLine("**************************************************************");

            Console.WriteLine("\n");

            Console.WriteLine("Résumé du compte épargne de Nicolas");
            Console.WriteLine("##############################################################");
            compteEpargneNicolas.AfficheResume();
            Console.WriteLine("##############################################################");

            Console.WriteLine("\n");

            Console.WriteLine("Résumé du compte de Jérémie");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\tSolde: {0}", compteJeremie.Solde);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}

