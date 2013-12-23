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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace PalIn
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Silaba : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        public static string path = "http://translate.google.com/translate_tts?tl=es&q=";

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


        public Silaba()
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

        private void hablar(string dato)
        {
            try
            {
                //speech.Speak(dato);
                med1.Source = new Uri(path + dato);
                med1.Play();
            }

            catch
            {
                //MessageBox.Show("Error al activar voz", "EcuaVoice Mobile", MessageBoxButton.OK);
            }

        }


        private void btnbra_Click(object sender, RoutedEventArgs e)
        {
            hablar("bra");
        }

        private void btnbre_Click(object sender, RoutedEventArgs e)
        {
            hablar("bre");
        }

        private void btnbri_Click(object sender, RoutedEventArgs e)
        {
            hablar("bri");
        }

        private void btnbro_Click(object sender, RoutedEventArgs e)
        {
            hablar("bro");
        }

        private void bntbru_Click(object sender, RoutedEventArgs e)
        {
            hablar("bru");
        }

        private void btncra_Click(object sender, RoutedEventArgs e)
        {
            hablar("cra");
        }

        private void btncre_Click(object sender, RoutedEventArgs e)
        {
            hablar("cre");
        }

        private void btncri_Click(object sender, RoutedEventArgs e)
        {
            hablar("cri");
        }

        private void btncro_Click(object sender, RoutedEventArgs e)
        {
            hablar("cro");
        }

        private void bntcru_Click(object sender, RoutedEventArgs e)
        {
            hablar("cru");
        }

        private void btndra_Click(object sender, RoutedEventArgs e)
        {
            hablar("dra");
        }

        private void btndre_Click(object sender, RoutedEventArgs e)
        {
            hablar("dre");
        }

        private void btndri_Click(object sender, RoutedEventArgs e)
        {
            hablar("dri");
        }

        private void btndro_Click(object sender, RoutedEventArgs e)
        {
            hablar("dro");
        }

        private void bntdru_Click(object sender, RoutedEventArgs e)
        {
            hablar("dru");
        }

        private void btnfra_Click(object sender, RoutedEventArgs e)
        {
            hablar("fra");
        }

        private void btnfre_Click(object sender, RoutedEventArgs e)
        {
            hablar("fre");
        }

        private void btnfri_Click(object sender, RoutedEventArgs e)
        {
            hablar("fri");
        }

        private void btnfro_Click(object sender, RoutedEventArgs e)
        {
            hablar("fro");
        }

        private void bntfru_Click(object sender, RoutedEventArgs e)
        {
            hablar("fru");
        }

        private void btnbla_Click(object sender, RoutedEventArgs e)
        {
            hablar("bla");
        }

        private void btnble_Click(object sender, RoutedEventArgs e)
        {
            hablar("ble");
        }

        private void btnbli_Click(object sender, RoutedEventArgs e)
        {
            hablar("bli");
        }

        private void btnblo_Click(object sender, RoutedEventArgs e)
        {
            hablar("blo");
        }

        private void bntblu_Click(object sender, RoutedEventArgs e)
        {
            hablar("blu");
        }

        private void btncla_Click(object sender, RoutedEventArgs e)
        {
            hablar("cla");
        }

        private void btncle_Click(object sender, RoutedEventArgs e)
        {
            hablar("cle");
        }

        private void btncli_Click(object sender, RoutedEventArgs e)
        {
            hablar("cli");
        }

        private void btnclo_Click(object sender, RoutedEventArgs e)
        {
            hablar("clo");
        }

        private void bntclu_Click(object sender, RoutedEventArgs e)
        {
            hablar("clu");
        }

        private void btnfla_Click(object sender, RoutedEventArgs e)
        {
            hablar("fla");
        }

        private void btnfle_Click(object sender, RoutedEventArgs e)
        {
            hablar("fle");
        }

        private void btnfli_Click(object sender, RoutedEventArgs e)
        {
            hablar("fli");
        }

        private void btnflo_Click(object sender, RoutedEventArgs e)
        {
            hablar("flo");
        }

        private void bntflu_Click(object sender, RoutedEventArgs e)
        {
            hablar("flu");
        }

        private void btngla_Click(object sender, RoutedEventArgs e)
        {
            hablar("gla");
        }

        private void btngle_Click(object sender, RoutedEventArgs e)
        {
            hablar("gle");
        }

        private void btngli_Click(object sender, RoutedEventArgs e)
        {
            hablar("gli");
        }

        private void btnglo_Click(object sender, RoutedEventArgs e)
        {
            hablar("glo");
        }

        private void bntglu_Click(object sender, RoutedEventArgs e)
        {
            hablar("glu");
        }



    }
}
