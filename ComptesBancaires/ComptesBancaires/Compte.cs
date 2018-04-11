using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesBancaires
{
    /*****************************************************************************************
	Classe abstraite compte
	*****************************************************************************************/
    public abstract class Compte
    {
        List<Operation> listeOperations;

        private string proprietaire;

        public string Proprietaire
        {
            get { return proprietaire; }
            set { proprietaire = value; }
        }


        /*****************************************************************************************
		Crédite l'instance d'un montant défini
		*****************************************************************************************/
        public void Crediter(decimal montant)
        {
            Operation op = new Operation()
            {
                TypeDeMouvement = Mouvement.Credit,
                Montant = montant,
            };

            listeOperations.Add(op);
        }

        /*****************************************************************************************
		Crédite l'instance d'un montant défini et débite une instance du même montant
		*****************************************************************************************/
        public void Crediter(decimal montant, Compte cmpt)
        {
            this.Crediter(montant);
            cmpt.Debiter(montant);
        }

        /*****************************************************************************************
		Débite l'instance d'un montant défini
		*****************************************************************************************/
        public void Debiter(decimal montant)
        {
            Operation op = new Operation()
            {
                TypeDeMouvement = Mouvement.Debit,
                Montant = montant,
            };

            listeOperations.Add(op);
        }

        /*****************************************************************************************
		Débite l'instance d'un montant défini et crédite une instance du même montant
		*****************************************************************************************/
        public void Debiter(decimal montant, Compte cmpt)
        {
            this.Debiter(montant);
            cmpt.Crediter(montant);
        }

        /*****************************************************************************************
		Retourne le solde de l'instance actuelle; le solde est calculé selon les opérations du compte
		*****************************************************************************************/
        virtual public decimal Solde
        {
            get
            {
                decimal total = 0;

                foreach (Operation op in listeOperations)
                {
                    if (op.TypeDeMouvement == Mouvement.Credit)
                    {
                        total += op.Montant;
                    }
                    else if (op.TypeDeMouvement == Mouvement.Debit)
                    {
                        total -= op.Montant;
                    }
                }

                return total;
            }
        }

        /*****************************************************************************************
		Affiche le contenu de la liste des opérations dans la console
		*****************************************************************************************/
        protected void AfficheOperations()
        {
            Console.WriteLine("Opérations: ");

            foreach (Operation op in listeOperations)
            {
                if (op.TypeDeMouvement == Mouvement.Credit)
                {
                    Console.WriteLine("\t+{0}", op.Montant);
                }
                else if (op.TypeDeMouvement == Mouvement.Debit)
                {
                    Console.WriteLine("\t-{0}", op.Montant);
                }
            }
        }

        /*****************************************************************************************
		Prototype de la fonction AfficheResume()
		*****************************************************************************************/
        public abstract void AfficheResume();

        /*****************************************************************************************
		Constructeur de la classe
		*****************************************************************************************/
        public Compte()
        {
            listeOperations = new List<Operation>();
        }
    }

    /*--------------------------------------------------------------------------*/
}

