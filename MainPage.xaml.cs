using System;
using System.Collections.Generic;
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

namespace AstronomieDatenbank
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        SolidColorBrush transparent = new SolidColorBrush(Colors.Transparent);


        private void BtnMerkur_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Merkur wechseln
        }

        private void BtnErde_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Erde wechseln
        }

        private void BtnVenus_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Venus wechseln
        }

        private void BtnJupiter_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Jupiter wechseln
        }

        private void BtnMars_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Mars wechseln
        }

        private void BtnUranus_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Uranus wechseln
        }

        private void BtnNeptun_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Neptun wechseln
        }

        private void BtnPluto_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Pluto wechseln
        }

        private void BtnSaturn_Click(object sender, RoutedEventArgs e)
        {
            //Auf Page Saturn wechseln
        }

        private void BtnMerkur_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnMerkur.Background = transparent;
        }

        private void BtnMerkur_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }

        private void BtnErde_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnErde.Background = transparent;
        }

        private void BtnErde_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnVenus_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnVenus.Background = transparent;
        }

        private void BtnVenus_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnJupiter_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnJupiter.Background = transparent;
        }

        private void BtnJupiter_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnMars_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnMars.Background = transparent;
        }

        private void BtnMars_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnUranus_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnUranus.Background = transparent;
        }

        private void BtnUranus_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnNeptun_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnNeptun.Background = transparent;
        }

        private void BtnNeptun_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnPluto_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnPluto.Background = transparent;
        }

        private void BtnPluto_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void BtnSaturn_MouseEnter(object sender, MouseEventArgs e)
        {
            BtnSaturn.Background = transparent;
        }

        private void BtnSaturn_MouseLeave(object sender, MouseEventArgs e)
        {

        }
    }
}
