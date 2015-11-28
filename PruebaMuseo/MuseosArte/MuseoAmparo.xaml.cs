using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using Windows.Devices.Geolocation;
using System.Device.Location;
using Windows.System;

namespace PruebaMuseo
{
    public partial class MuseoAmparo : PhoneApplicationPage
    {
        public MuseoAmparo()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask phoneCallTask = new PhoneCallTask();
            phoneCallTask.PhoneNumber = "2293850";
            phoneCallTask.DisplayName = "Museo Amparo";
            phoneCallTask.Show();
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            var locator = new Geolocator();
            //MessageBox.Show("¿Está seguro de querer abrir Mapas?", "Cómo llegar.",MessageBoxButton.OKCancel);

            MessageBoxResult m = MessageBox.Show("Trazar una ruta hacia el museo.", "¿Quieres saber cómo llegar?", MessageBoxButton.OKCancel);
            if (m == MessageBoxResult.Cancel)
            {

            }
            else
            {
                //MessageBox.Show("Data Deleted", "Done", MessageBoxButton.OK);
                String Latitud;
                String Longitud;

                if (!locator.LocationStatus.Equals(PositionStatus.Disabled))
                {
                    var position = await locator.GetGeopositionAsync();
                    Latitud = position.Coordinate.Point.Position.Latitude.ToString();
                    Longitud = position.Coordinate.Point.Position.Longitude.ToString();
                }

                else
                {
                    return;
                }

                double Latitud2 = Convert.ToDouble(Latitud);
                double Longitud2 = Convert.ToDouble(Longitud);

                BingMapsDirectionsTask bing = new BingMapsDirectionsTask()
                {
                    //Giving label and coordinates to starting and ending points. 

                    Start = new LabeledMapLocation("Ubicación actual", new GeoCoordinate(Latitud2, Longitud2)),
                    End = new LabeledMapLocation("Museo Amparo", new GeoCoordinate(19.040706, -98.198749))
                };
                // Launching Bing Maps Direction Tasks
                bing.Show();
            }
        }

        private async void btnPagina_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("http://museoamparo.com/"));
        }

        private async void btnFacebook_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("fb:pages?id=165607966813702"));
        }
    }
}