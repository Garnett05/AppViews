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
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();

            TxtJersey.Completed += delegate (object sender, EventArgs args)
            {
                if (TxtJersey.Text == "05")
                {
                    DisplayAlert("Yeah", "You are goddamn right!", "Ok");
                }
                else
                {
                    DisplayAlert("Oh no", "You are a shame for me and my family", "Ok");
                }
            };
            TxtJersey.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {              
                Lbl.Text = args.NewTextValue;
            };
            TxtComment.Completed += delegate (object sender, EventArgs args)
            {
                Lbl_2.Text = TxtComment.Text.Length.ToString();
            };
        }
    }
}