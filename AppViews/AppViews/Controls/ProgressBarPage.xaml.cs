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
    public partial class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            InitializeComponent();
        }
        public void ModifyProgress (object sender, EventArgs args)
        {
            Bar1.Progress = 1;
            Bar2.ProgressTo(1, 5000, Easing.Linear); //Alguns tipos de animação na classe Easing
            Bar3.ProgressTo(1, 5000, Easing.SpringIn);
            Bar4.ProgressTo(1, 5000, Easing.SpringOut);
            Bar5.ProgressTo(1, 5000, Easing.BounceIn);
            Bar6.ProgressTo(1, 5000, Easing.BounceOut);
            Bar7.ProgressTo(1, 5000, Easing.CubicIn);
            Bar8.ProgressTo(1, 5000, Easing.CubicOut);
            Bar9.ProgressTo(1, 5000, Easing.SinIn);
            Bar10.ProgressTo(1, 5000, Easing.SinOut);
        }
    }
}