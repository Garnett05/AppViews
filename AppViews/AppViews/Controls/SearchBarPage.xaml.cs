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
    public partial class SearchBarPage : ContentPage
    {
        private List<String> nbaTeams;
        public SearchBarPage()
        {
            InitializeComponent();
            nbaTeams = new List<string>();
            nbaTeams.Add("Celtics");
            nbaTeams.Add("Raptors");
            nbaTeams.Add("Sixers");
            nbaTeams.Add("Knicks");
            nbaTeams.Add("Nets");
            nbaTeams.Add("Bucks");
            nbaTeams.Add("Heat");
            nbaTeams.Add("Hawks");
            nbaTeams.Add("Pacers");
            nbaTeams.Add("Magic");
            nbaTeams.Add("Wizards");
            nbaTeams.Add("Hornets");
            nbaTeams.Add("Bulls");
            nbaTeams.Add("Pistons");
            nbaTeams.Add("Cavs");
            //----------------------
            nbaTeams.Add("Lakers");
            nbaTeams.Add("Clippers");
            nbaTeams.Add("Nuggets");
            nbaTeams.Add("Jazz");
            nbaTeams.Add("Thunder");
            nbaTeams.Add("Rockets");
            nbaTeams.Add("Mavs");
            nbaTeams.Add("Grizzlies");
            nbaTeams.Add("Blazers");
            nbaTeams.Add("Pelicans");
            nbaTeams.Add("Kings");
            nbaTeams.Add("Spurs");
            nbaTeams.Add("Suns");
            nbaTeams.Add("Wolves");
            nbaTeams.Add("Warriors");
                        
            FeedingStack(nbaTeams);
        }
        private void Search(object sender, TextChangedEventArgs args)
        {
            var result = nbaTeams.Where(x => x.Contains(args.NewTextValue)).ToList<string>();
            FeedingStack(result);
        }
        private void SearchButton(object sender, EventArgs args)
        {
            var result = nbaTeams.Where(x => x.Contains(((SearchBar)sender).Text)).ToList();
            FeedingStack(result);
        }
        private void FeedingStack(List<String> nbaTeams)
        {
            listResult.Children.Clear();
            foreach (string team in nbaTeams)
            {
                listResult.Children.Add(new Label { Text = team, FontSize = 24 });
            }            
        }
    }
}