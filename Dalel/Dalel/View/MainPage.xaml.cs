using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Dalel.Model;
using Dalel.View;

namespace Dalel
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void LocationsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
           LocationInfo Location = e.Item as LocationInfo;


             await Navigation.PushAsync(new LocationDetails(Location));
           
           
        }
    }
}
