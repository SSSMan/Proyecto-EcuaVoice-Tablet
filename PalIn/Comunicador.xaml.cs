using PalIn.Common;
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
using Windows.UI.Popups;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace PalIn
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Comunicador : Page
    {

        public static string path = "http://translate.google.com/translate_tts?tl=es&q=";
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public Comunicador()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void SeleccionarPictograma(string palabra)
        {
            try
            {
                txbTexto.Text = txbTexto.Text + palabra + " ";
            }

            catch
            {
                //MessageBox.Show("Error al selecionar pictograma", "EcuaVoice Mobile", MessageBoxButton.OK);
            }

        }

        private void btnQuiero_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("quiero");
        }

        private void btnYo_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("Yo");
        }

        private void btnTu_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("tu");
        }

        private void btnEl_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("el");
        }

        private void btnElla_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("ella");
        }

        private void btnNoQuiero_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("no quiero");
        }

        private void btnComer_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("comer");
        }

        private void btnJugar_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("jugar");
        }

        private void btnAgua_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("agua");
        }

        private void btnGalletas_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("galletas");
        }

        private void btnLeche_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("leche");
        }

        private void btnSopa_Click(object sender, RoutedEventArgs e)
        {
            SeleccionarPictograma("sopa");
        }


        private void btnHablar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbTexto.Text != "")
                {
                    med1.Source = new Uri(path + txbTexto.Text);
                    med1.Play();
                }
                else
                {
                    //MessageBox.Show("Seleccione Pictogramas", "EcuaVoice Mobile", MessageBoxButton.OK);
                    MessageDialog messageDialog = new MessageDialog("Seleccione Pictogramas", "EcuaVoice Mobile");
                }
            }

            catch
            {
                MessageDialog messageDialog = new MessageDialog("Error al activar voz digitalizada", "EcuaVoice Mobile");
            }

        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            txbTexto.Text = "";
        }

        private void btnParar_Click(object sender, RoutedEventArgs e)
        {
            med1.Stop();
        }

    }
}
