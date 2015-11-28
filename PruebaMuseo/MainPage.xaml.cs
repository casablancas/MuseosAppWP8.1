using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PruebaMuseo.Resources;

namespace PruebaMuseo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.WaitForFiveSeconds();
        }
        private async void WaitForFiveSeconds()
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(3));
            NavigationService.Navigate(new Uri("/Inicio.xaml", UriKind.Relative));
        }
    }
}