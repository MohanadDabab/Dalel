using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dalel.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dalel.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LocationDetails : ContentPage
	{
        

        public LocationDetails ()
		{
			InitializeComponent();

          
        }

        public LocationDetails(LocationInfo location)
        {
            InitializeComponent();


            LocationImage.Source = location.LocationPic;
            LocationNameLabel.Text = location.LocationName;
            LocationCatLabel.Text = location.LocationCat;

           var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<html><body dir=""rtl"">
    <p>"+location.LocationDes+@"</p>
  </body></html>";
            browser.Source = htmlSource;
        }
    }
}