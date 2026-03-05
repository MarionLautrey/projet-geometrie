using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Ellipse = System.Windows.Shapes.Ellipse;
using System.Windows.Ink;
using System.Windows.Media.Media3D;
using System.Windows;

namespace Projet_geometrie
{
    public class ClasseCercle : ClasseRond
    {
        #region Méthodes

        public ClasseCercle() : base() 
        { 

        }

        // Dessinne un cercle 
        public void Dessin(Canvas canvasCercle)
        {
            foreach (var child in canvasCercle.Children)
            {
                if (child is Ellipse)
                {
                    MessageBox.Show("Le cercle a déjà été dessiné.");
                    return;  // Si un cercle existe déjà, ne pas en dessiner un nouveau
                }
            }
            Ellipse oCercle = new Ellipse()
            {
                Width = this.Get_unUneValeur() * 10,
                Height = this.Get_unUneValeur() * 10,
                Stroke = Brushes.Black,
                StrokeThickness = 4,
            };
            canvasCercle.Children.Add(oCercle);
        }

        // On initialise
        public static new void Init()
        {
            throw new InvalidOperationException("Pas de constructeur par défaut disponible.");
        }

        //fPerimetre calcul et renvoi le périmètre des valeurs des variables de classe
        public float Perimetre()
        {
            float fResultat = 0;
            fResultat = 2 * (float)3.14 * this.unUneValeur;
            return fResultat;
        }

        //fSurface calcul et renvoi la surface des valeurs des variables de classe
        public float Surface()
        {
            float fResultat = 0;
            fResultat = (float)3.14 * this.unUneValeur * this.unUneValeur;
            return fResultat;
        }
        #endregion
    }
}