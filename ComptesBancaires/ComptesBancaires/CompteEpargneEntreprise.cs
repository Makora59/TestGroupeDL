using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesBancaires
{
    class CompteEpargneEntreprise : Compte
    {
        private double tauxAbondement;

        public CompteEpargneEntreprise(double taux)
        {
            tauxAbondement = taux;
        }

        /*****************************************************************************************
		Retourne le solde avec le taux spécificé par l'instance
		*****************************************************************************************/
        public override decimal Solde
        {
            get
            {
                return base.Solde * (decimal)(1 + tauxAbondement);
            }
        }

        /*****************************************************************************************
		Affiche les informations de l'instance dans la console
		*****************************************************************************************/
        public override void AfficheResume()
        {
            Console.WriteLine("Compte épargne entreprise de {0}", this.Proprietaire);
            Console.WriteLine("\tSolde: {0}", this.Solde);
            Console.WriteLine("\tTauxd\'abondement: {0}", this.tauxAbondement);
            Console.WriteLine("\n");
            AfficheOperations();
        }
    }
}
