using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesBancaires
{
    class CompteCourant : Compte
    {
        private decimal decouvertAutorise;

        public CompteCourant(decimal decouvert)
        {
            decouvertAutorise = decouvert;
        }

        public override void AfficheResume()
        {
            Console.WriteLine("Compte courant de {0}", this.Proprietaire);
            Console.WriteLine("\tSolde: {0}", this.Solde);
            Console.WriteLine("\tDécouvert autorisé: {0}", this.decouvertAutorise);
            Console.WriteLine("\n");
            AfficheOperations();
        }
    }
}
