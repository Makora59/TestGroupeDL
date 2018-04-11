using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesBancaires
{
    /*****************************************************************************************
    Mouvement disponibles pour les opérations banquaires
    *****************************************************************************************/
    public enum Mouvement
    {
        Credit,
        Debit,
    }

    /*--------------------------------------------------------------------------*/

    /*****************************************************************************************
	Défini une opération banquaire. Chaque opération a son type d'opération (débit ou crédit)
	qui sera appliquée avec le montant défini 
	*****************************************************************************************/   
    class Operation
    {
        private Mouvement typeDeMouvement;

        public Mouvement TypeDeMouvement
        {
            get { return typeDeMouvement; }
            set { typeDeMouvement = value; }
        }


        private decimal montant;

        public decimal Montant
        {
            get { return montant; }
            set { montant = value; }
        }

    }
}
