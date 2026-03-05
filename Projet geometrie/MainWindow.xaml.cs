using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Diagnostics;
using System.Windows.Controls.Primitives;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;

namespace Projet_geometrie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClasseCarre oCarre = new ClasseCarre();
        ClasseRectangle oRectangle = new ClasseRectangle();
        ClasseTriangle oTriangle = new ClasseTriangle();
        ClasseCercle oCercle = new ClasseCercle();
        public MainWindow()
        {
            //Génère la page Windows
            InitializeComponent();

        }

        private void BtnAfficher_Click(object sender, RoutedEventArgs e)
        {
            if (RdoCarre.IsChecked == true)
            {
                canvasDessin.Children.Clear();
                oCarre.Dessin(canvasDessin);
                txtLongueur.Text = oCarre.Get_unUneValeur() + " cm";
            }
            else if (RdoRectangle.IsChecked == true)
            {
                canvasDessin.Children.Clear();
                oRectangle.Dessin(canvasDessin);
                txtLongueur.Text = oRectangle.Get_unUneValeur() + " cm";
                txtLargeur.Text = oRectangle.Get_unLargeur() + " cm";
            }
            else if (RdoTriangle.IsChecked == true)
            {
                canvasDessin.Children.Clear();
                oTriangle.Dessin(canvasDessin);
                txtLongueur.Text = oTriangle.Get_unC2() + " cm";
                txtLargeur.Text = oTriangle.Get_unC1() + " cm";
                txtHauteur.Text = oTriangle.Get_unHaut() + " cm";
            }
            else if (RdoCercle.IsChecked == true)
            {
                canvasDessin.Children.Clear();
                oCercle.Dessin(canvasDessin);
                txtRayon.Text = oCercle.Get_unUneValeur() + " cm";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une forme avant de dessiner ", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            if (RdoCarre.IsChecked == true)
            {
                resultatP_Attendus.Text = oCarre.Perimetre().ToString();
                resultatS_Attendus.Text = oCarre.Surface().ToString();

                if (resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString())
                {
                    MessageBox.Show("Bravo vous avez trouvé la bonne réponse ! ");
                }
                else if (resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString())
                {
                    resultatP_Attendus.Text = "";
                    resultatS_Attendus.Text = "";
                    MessageBox.Show("Faux !");
                }
            }
            else if (RdoRectangle.IsChecked == true)
            {
                resultatP_Attendus.Text = oRectangle.Perimetre().ToString();
                resultatS_Attendus.Text = oRectangle.Surface().ToString();

                if (resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString())
                {
                    MessageBox.Show("Bravo vous avez trouvé la bonne réponse ! ");
                }
                else if (resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString())
                {
                    resultatP_Attendus.Text = "";
                    resultatS_Attendus.Text = "";
                    MessageBox.Show("Faux !");
                }
            }
            else if (RdoTriangle.IsChecked == true)
            {
                resultatP_Attendus.Text = oTriangle.fPerimetre().ToString();
                resultatS_Attendus.Text = oTriangle.fSurface().ToString();
                MessageBox.Show(resultatP_Attendus.ToString() + resultatS_Attendus.ToString());

                if (resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString())
                {
                    MessageBox.Show("Bravo vous avez trouvé la bonne réponse ! ");
                }
                else if (resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString())
                {
                    resultatP_Attendus.Text = "";
                    resultatS_Attendus.Text = "";
                    MessageBox.Show("Faux !");
                }
            }
            else if (RdoCercle.IsChecked == true)
            {
                resultatP_Attendus.Text = oCercle.Perimetre().ToString();
                resultatS_Attendus.Text = oCercle.Surface().ToString();
                MessageBox.Show(resultatP_Attendus.ToString() + resultatS_Attendus.ToString());

                if (resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString())
                {
                    MessageBox.Show("Bravo vous avez trouvé la bonne réponse ! ");
                }
                else if (resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() == resultatP_Attendus.ToString() && resultatS.ToString() != resultatS_Attendus.ToString() || resultatP.ToString() != resultatP_Attendus.ToString() && resultatS.ToString() == resultatS_Attendus.ToString()){
                    resultatP_Attendus.Text = "";
                    resultatS_Attendus.Text = "";
                    MessageBox.Show("Faux !");
                }
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            // Réinitialiser les zones de texte et dessin
            txtHauteur.Text = String.Empty;
            txtLargeur.Text = String.Empty;
            txtLongueur.Text = String.Empty;
            txtRayon.Text = String.Empty;
            resultatP.Text = String.Empty;
            resultatS.Text = String.Empty;
            resultatS_Attendus.Text = String.Empty;
            resultatP_Attendus.Text = String.Empty;
            canvasDessin.Children.Clear();
        }

        private void Button_quitter(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}