using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppViews.Model;

namespace AppViews.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            List<People> list = new List<People>();
            list.Add(new People { Name = "Rajon Rondo", Age = 34 });
            list.Add(new People { Name = "White Mamba", Age = 42 });
            list.Add(new People { Name = "Paul Pierce", Age = 42 });
            list.Add(new People { Name = "Kevin Garnett", Age = 43 });
            list.Add(new People { Name = "Kendrick Perkins", Age = 35 });            

            listPeoples.ItemsSource = list;
        }
    }
}