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
	public partial class CobaNavHierarchy1 : ContentPage
	{
		public CobaNavHierarchy1 ()
		{
			InitializeComponent ();

            // CabaNav #1
            btnHalDua.Clicked += async (sender, e) => await Navigation.PushAsync(new CobaNavHierarchy2());

            // CobaNav #6
            //btnHalDua.Clicked += async (sender, e) => await Navigation.PushAsync(new CobaNavHierarchy2(etrNama.Text));
        }
	}
}