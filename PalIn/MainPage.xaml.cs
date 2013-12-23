using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PalIn
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btndato_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            //txtnombre.Text = "sdfds";
            ////txt

            //var itemId = ((SampleDataItem)e.ClickedItem).UniqueId;
            //this.Frame.Navigate(typeof(ItemDetailPage), itemId);

            //NavigationService.Navigate(new Uri("/winTrabalenguas.xaml", UriKind.Relative));
            //Comunicador obj = new Comunicador();
            //obj.


                
        }

        private void btnParesMinimos_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pares));
        }

        private void btnLector_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Lectora));
          
        }

        private void btnTrabalenguas_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Trabalenguas));
        }

        private void btnRimas_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Rimas));
        }

        private void btnSilabasCompuestas_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Silaba));
        }

        private void btnDeletreos_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/winDeletreos.xaml", UriKind.Relative));
        }

        private void btnComunicador_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Comunicador));
        }

        private void btnfonemas_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Fonemas));
        }
    }
}
