using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CobaNav
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CobaNavModal2 : ContentPage
	{
		public CobaNavModal2 ()
		{
			InitializeComponent ();
            //lblId.Text = "ID dari objek: " + (string)Application.Current.Properties["id"];

            btnHalSatu.Clicked += async (sender, e) => await Navigation.PopModalAsync();
		}
	}
}