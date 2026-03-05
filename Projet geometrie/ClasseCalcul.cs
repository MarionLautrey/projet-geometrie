using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_geometrie
{
    public class ClasseCalcul
    {
        #region Champs
        protected ushort unUneValeur;
        #endregion

        #region Méthodes
        //Constructeur par défaut
        public ClasseCalcul()
        {
            Init();
        }

        //Constructeur paramétré
        public ClasseCalcul(ushort unUneValeurParametre)
        {          
            Set_unUneValeur(unUneValeurParametre);
        }

        //Finaliseur
        ~ClasseCalcul()
        {            
            this.unUneValeur = 0;
        }

        //Accesseurs
        public ushort Get_unUneValeur()
        {
            return this.unUneValeur;
        }

        //Mutateurs
        public void Set_unUneValeur(ushort unUneValeurSet)
        {
            this.unUneValeur = unUneValeurSet;
        }

        //On initialise l'entier UneValeur avec une valeur aléatoire comprise entre 0 et 10
        protected void Init()
        {
            Random oNb = new Random();
            //Transtypage de l'entier random en short non signé
            unUneValeur = (ushort)oNb.Next(1, 11);
        }

        protected int Addition(int v1, int v2)
        {
            int iResultat = 0;
            iResultat = v1 + v2;
            return iResultat;
        }

        protected int Multiplication(int v1, int v2)
        {
            int iResultat = 0;
            iResultat = v1 * v2;
            return iResultat;
        }
        #endregion
    }
}
