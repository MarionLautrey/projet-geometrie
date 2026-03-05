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
    public class ClasseCarre : Classe4Angles
    {
        #region Méthodes
        public ClasseCarre() : base()
        {

        }

        // On dessine un carré
        public void Dessin(Canvas canvasCarre)
        {
            foreach (var child in canvasCarre.Children)
            {
                if (child is Rectangle)
                {
                    MessageBox.Show("Le carré a déjà été dessiné.");
                    return;  // Si un carré existe déjà, ne pas en dessiner un nouveau
                }
            }
            Rectangle oCarre = new Rectangle
            {
            Width = this.Get_unUneValeur()*10,
            Height = this.Get_unUneValeur()*10,
            Stroke = Brushes.Black,
            StrokeThickness = 4,
            };
            canvasCarre.Children.Add(oCarre);
        }
        // On initialise
        protected new void Init()
        {
            throw new InvalidOperationException("Pas de constructeur par défaut disponible.");
        }

        // fPerimetre calcul et renvoi le périmètre des valeurs des variables de classe
        public float Perimetre()
        {
            float fResultat = 0;
            fResultat = 4 * this.unUneValeur;
            return fResultat;
        }

        // fSurface calcul et renvoi la surface des valeurs des variables de classe
        public float Surface()
        {
            float fResultat = 0;
            fResultat = this.unUneValeur * this.unUneValeur;
            return fResultat;
        }        
        #endregion
    }
}
