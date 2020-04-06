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
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {            
            InitializeComponent();
            datePicker.Date = DateTime.Now;
        }
        public void ActinoDateSelected (object sender, DateChangedEventArgs args)
        {
            lblResult.Text = args.OldDate.ToString("dd/MM/yyyy") + " - " + args.NewDate.ToString("dd/MM/yyyy");
        }
    }
}