using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Shapes;
using Rectangle = System.Windows.Shapes.Rectangle;
using System.Windows;

namespace Projet_geometrie
{
    public class ClasseRectangle:Classe4Angles
    {
        #region Champs
        protected ushort unLargeur = 0;
        #endregion

        #region Méthodes
        public ClasseRectangle()
        {

            Init();
        }

        //Constructeur paramétré
        public ClasseRectangle(ushort unLargeurParametre)
        {
            Set_unLargeur(unLargeurParametre);
        }

        //Finaliseur
        ~ClasseRectangle()
        {
            this.unLargeur = 0;
        }
        //Accesseurs
        public ushort Get_unLargeur()
        {
            return this.unLargeur;
        }

        //Mutateurs
        public void Set_unLargeur(ushort unLargeurSet)
        {
            this.unLargeur = unLargeurSet;
        }
        // On dessine un rectangle
        public void Dessin(Canvas canvasRectangle)
        {
            foreach (var child in canvasRectangle.Children)
            {
                if (child is Rectangle)
                {
                    MessageBox.Show("Le rectangle a déjà été dessiné.");
                    return;  // Si un rectangle existe déjà, ne pas en dessiner un nouveau
                }
            }

            Rectangle oRectangle = new Rectangle()
            {
                Width = this.Get_unLargeur()*10,
                Height = this.Get_unUneValeur()*10,
                Stroke = Brushes.Black,
                StrokeThickness = 4,
            };
            canvasRectangle.Children.Add(oRectangle);
        }
        //On initialise l'entier unLargeur avec une valeur aléatoire comprise entre 0 et 10
        protected new void Init()
        {
            Random oNb = new Random();
            unLargeur = (ushort)oNb.Next(1, 11);
        }
        
        // fPerimetre calcul et renvoi le périmètre des valeurs des variables de classe
        public float Perimetre()
        {
            float fResultat = 0;
            fResultat = 2 * this.unUneValeur + 2 * this.unLargeur;
            return fResultat;
        }
        //fSurface calcul et renvoi la surface des valeurs des variables de classe
        public float Surface()
        {
            float fResultat = 0;
            fResultat = this.unUneValeur * this.unLargeur;
            return fResultat;
        }
       
        #endregion
    }
}

