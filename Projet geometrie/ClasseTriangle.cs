using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media;
using Polygon = System.Windows.Shapes.Polygon;
using System.Windows.Shapes;
using System.Windows;

namespace Projet_geometrie
{
    public class ClasseTriangle : ClasseAvecAngle
    {
        #region Champs
        protected ushort unC1;
        protected ushort unC2;
        protected ushort unHaut;
        #endregion

        #region Méthodes

        public ClasseTriangle()
        {
            Init();
        }

        //Constructeur paramétré
        public ClasseTriangle(ushort unC1Parametre, ushort unC2Parametre, ushort unHautParametre)
        {
            Set_unC1(unC1Parametre);
            Set_unC2(unC2Parametre);
            Set_unHaut(unHautParametre);
        }

        //Finaliseur
        ~ClasseTriangle()
        {
            this.unC1 = 0;
            this.unC2 = 0;
            this.unHaut = 0;
        }
        //Accesseurs
        public ushort Get_unC1()
        {
            return this.unC1;
        }
        public ushort Get_unC2()
        {
            return this.unC2;

        }
        public ushort Get_unHaut()
        {
            return this.unHaut;
        }

        //Mutateurs modifier variable de classe
        public void Set_unC1(ushort unC1Set)           
        {
           this.unC1 = unC1Set;        
        }
        public void Set_unC2(ushort unC2Set)
        {
            this.unC2 = unC2Set;       
        }
        public void Set_unHaut(ushort unHautSet)
        {
            this.unHaut = unHautSet;
        }
        // On dessine un triangle
        public void Dessin(Canvas canvasTriangle)
        {
            foreach (var child in canvasTriangle.Children)
            {
                if (child is Polygon)
                {
                    MessageBox.Show("Le triangle a déjà été dessiné.");
                    return;  // Si un triangle existe déjà, ne pas en dessiner un nouveau
                }
            }
            Polygon oTriangle = new Polygon();
            oTriangle.Stroke = System.Windows.Media.Brushes.Black;
            oTriangle.Fill = System.Windows.Media.Brushes.LightSeaGreen;
            oTriangle.StrokeThickness = 2;
            oTriangle.HorizontalAlignment = HorizontalAlignment.Left;
            oTriangle.VerticalAlignment = VerticalAlignment.Center;
            System.Windows.Point Point1 = new System.Windows.Point(10, unHaut * 10 + 10);            // bas gauche
            System.Windows.Point Point2 = new System.Windows.Point(unC1 * 10 + 10, unHaut * 10 + 10); // bas droite
            System.Windows.Point Point3 = new System.Windows.Point((unC1 * 10) / 2 + 10, 10);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            oTriangle.Points = myPointCollection;
            canvasTriangle.Children.Add(oTriangle);
        }
        // On initialise
        protected new void Init()
        {
            Random oNb = new Random();
            unC1 = (ushort)oNb.Next(1, 11);
            unC2 = (ushort)oNb.Next(1, 11);
            unHaut = (ushort)oNb.Next(1, 11);
        }

        // fPerimetre calcul et renvoi le périmètre des valeurs des variables de classe
        public float fPerimetre()
        {
            float fResultat = 0;
            fResultat = this.unC1 + this.unC2 + this.unHaut;
            return fResultat;
        }
        //fSurface calcul et renvoi la surface des valeurs des variables de classe
        public float fSurface()
        {
            float fResultat = 0;
            fResultat = (this.unC1 * this.unHaut) / 2;
            return fResultat;
        }
       
        #endregion
    }
}
