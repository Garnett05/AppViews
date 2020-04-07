using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViews.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }
        public void GoPage(object sender, EventArgs args)
        {
            browser.Source = siteAdress.Text;
        }
        public void GoNextPage (object sender, EventArgs args)
        {
            if (browser.CanGoForward)
            {
                browser.GoForward();
            }
        }
        public void GoPreviousPage(object sender, EventArgs args)
        {
            if (browser.CanGoBack)
            {
                browser.GoBack();
            }
        }
        public void ActionLoading (object sender, EventArgs args)
        {
            lblStatus.Text = "Loading";
        }
        public void ActionLoaded (object sender, EventArgs args)
        {
            lblStatus.Text = "Finalized";
        }
    }
}