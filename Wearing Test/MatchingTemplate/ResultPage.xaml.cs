using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace MatchingTemplate
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class ResultPage : MatchingTemplate.Common.LayoutAwarePage
    {
        public ResultPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            iResults.Text = "Corrrect : " + (navigationParameter as Array).GetValue(0).ToString();
            iResults.Text += "\nWrong : " + (navigationParameter as Array).GetValue(1).ToString();
            iResults.Text += "\nTime Elapsed :\n" + TimeString(Convert.ToInt64((navigationParameter as Array).GetValue(2)));
        }

        string TimeString(long seconds)
        {
            int hh = Convert.ToInt32(seconds / 3600);
            int mm = Convert.ToInt32((seconds / 60) % 60);
            int ss = Convert.ToInt32(seconds % 60);
            return ((hh == 0) ? "" : hh.ToString("00") + "hours, ") +
                ((mm == 0) ? "" : mm.ToString("00") + " minutes, ")
                + ss.ToString("00") + " seconds";
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        void OnPlayAgain(Object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HubPage));
        }
    }
}
