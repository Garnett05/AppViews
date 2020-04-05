using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViews.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }
        private void GoActivityIndicatorPage (object sender, EventArgs args)
        {
            Detail = new Controls.ActivityIndicatorPage();
        }        
        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new Controls.ProgressBarPage();
        }
        private void GoBoxViewPage (object sender, EventArgs args)
        {
            Detail = new Controls.BoxViewPage();
        }
    }
}