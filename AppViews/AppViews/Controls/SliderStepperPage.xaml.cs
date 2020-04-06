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
    public partial class SliderStepperPage : ContentPage
    {
        public SliderStepperPage()
        {
            InitializeComponent();
        }
        private void ActionChangeValue (object sender, ValueChangedEventArgs args)
        {
            sliderResult.Text = args.NewValue.ToString();
        }
        private void ActionStepperChangeValue (object sender, ValueChangedEventArgs args)
        {
            stepperResult.Text = args.NewValue.ToString();
        }
    }
}