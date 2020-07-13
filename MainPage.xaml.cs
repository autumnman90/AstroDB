﻿using Astro_DB;
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
            bool mousemerkur = false;
            bool mouseerde = false;
            bool mousevenus = false;
            bool mousejupiter = false;
            bool mousemars = false;
            bool mouseuranus = false;
            bool mouseneptun = false;
            bool mousepluto = false;
            bool mousesaturn = false;
            public MainPage()
            {
                InitializeComponent();
                 SolidColorBrush transparent = new SolidColorBrush(Colors.Transparent);
            }

            SolidColorBrush transparent = new SolidColorBrush(Colors.Transparent);


            private void BtnMerkur_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Merkur()); //Auf Page Merkur wechseln
            }

            private void BtnErde_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Erde());//Auf Page Erde wechseln
            }

            private void BtnVenus_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Venus());//Auf Page Venus wechseln
            }

            private void BtnJupiter_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Jupiter());//Auf Page Jupiter wechseln
            }

            private void BtnMars_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Mars());//Auf Page Mars wechseln
            }

            private void BtnUranus_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Uranus());//Auf Page Uranus wechseln
            }

            private void BtnNeptun_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Neptun());//Auf Page Neptun wechseln
            }

            private void BtnPluto_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Pluto());//Auf Page Pluto wechseln
            }

            private void BtnSaturn_Click(object sender, RoutedEventArgs e)
            {
                NavigationService.Navigate(new Saturn());//Auf Page Saturn wechseln
            }

            private void BtnMerkur_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnMerkur.Background = transparent;

                if (mousemerkur == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mousemerkur = true;
                }
            }

            private void BtnMerkur_MouseLeave(object sender, MouseEventArgs e)
            {
                if (mousemerkur = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mousemerkur = false;
                }
            }

            private void BtnErde_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnErde.Background = transparent;
                if (mouseerde == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mouseerde = true;
                }

            }

            private void BtnErde_MouseLeave(object sender, MouseEventArgs e)
            {

                if (mouseerde = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mouseerde = false;
                }

            }

            private void BtnVenus_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnVenus.Background = transparent;
                if (mousevenus == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mousevenus = true;
                }

            }

            private void BtnVenus_MouseLeave(object sender, MouseEventArgs e)
            {

                if (mousevenus = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mousevenus = false;
                }

            }

            private void BtnJupiter_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnJupiter.Background = transparent;
                if (mousejupiter == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mousejupiter = true;
                }

            }

            private void BtnJupiter_MouseLeave(object sender, MouseEventArgs e)
            {
                if (mousejupiter = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mousejupiter = false;
                }

            }

            private void BtnMars_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnMars.Background = transparent;
                if (mousemars == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mousemars = true;
                }

            }

            private void BtnMars_MouseLeave(object sender, MouseEventArgs e)
            {
                if (mousemars = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mousemars = false;
                }

            }

            private void BtnUranus_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnUranus.Background = transparent;
                if (mouseuranus == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mouseuranus = true;
                }

            }

            private void BtnUranus_MouseLeave(object sender, MouseEventArgs e)
            {
                if (mouseuranus = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mouseuranus = false;
                }

            }

            private void BtnNeptun_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnNeptun.Background = transparent;
                if (mouseneptun == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mouseneptun = true;
                }

            }

            private void BtnNeptun_MouseLeave(object sender, MouseEventArgs e)
            {

                if (mouseneptun = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mouseneptun = false;
                }

            }

            private void BtnPluto_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnPluto.Background = transparent;
                if (mousepluto == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mousepluto = true;
                }

            }

            private void BtnPluto_MouseLeave(object sender, MouseEventArgs e)
            {
                if (mousepluto = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mousepluto = false;
                }

            }

            private void BtnSaturn_MouseEnter(object sender, MouseEventArgs e)
            {
                BtnSaturn.Background = transparent;
                if (mousesaturn == false)
                {
                    Planetinfo.Visibility = Visibility.Visible;
                    mousesaturn = true;
                }

            }

            private void BtnSaturn_MouseLeave(object sender, MouseEventArgs e)
            {
                if (mousesaturn = true)
                {
                    Planetinfo.Visibility = Visibility.Hidden;
                    mousesaturn = false;
                }

            }
        }
    }
