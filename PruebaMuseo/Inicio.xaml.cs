using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PruebaMuseo
{
    public partial class Inicio : PhoneApplicationPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public void btnAmparo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosArte/MuseoAmparo.xaml", UriKind.Relative));
        }

       public void btnBarrioArtista(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosArte/BarrioArtista.xaml", UriKind.Relative));
        }

        //Método para evitar que el botón "back" se regrese a la pantalla de SplashScreen.
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnComplejo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosArte/CCU.xaml", UriKind.Relative));
        }

        private void btnTecDeMonterrey(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosArte/TecDeMonterrey.xaml", UriKind.Relative));
        }

        private void btnFototeca(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosArte/FototecaJuan.xaml", UriKind.Relative));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosArte/GaleriaArte.xaml", UriKind.Relative));
        }

        private void btnImagina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosInteractivos/MuseoImagina.xaml", UriKind.Relative));
        }

        private void btnPlanetario_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosInteractivos/Planetario.xaml", UriKind.Relative));
        }

        private void btnViviente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosInteractivos/MuseoViviente.xaml", UriKind.Relative));
        }

        private void btnTalavera_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosInteractivos/Talavera.xaml", UriKind.Relative));
        }

        private void btnSerdan_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MuseosHistoria/Serdan.xaml", UriKind.Relative));
        }
    }
}