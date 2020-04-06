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
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }
        private void ActionSwitch (object sender, ToggledEventArgs args)
        {
            lblResult.Text = DateTime.Now.ToString("HH:mm:ss") + " - " + args.Value;
        }
    }
}