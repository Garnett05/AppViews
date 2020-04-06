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
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
        }
        private void ActionMudarIndex (object sender, EventArgs args)
        {
            Picker obj = (Picker)sender;
            result.Text = obj.SelectedItem.ToString()+ ", index: " + obj.SelectedIndex.ToString();
        }
    }
}