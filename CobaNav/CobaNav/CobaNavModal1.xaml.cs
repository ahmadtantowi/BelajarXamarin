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
	public partial class CobaNavModal1 : ContentPage
	{
		public CobaNavModal1 ()
		{
			InitializeComponent ();

            btnHalDua.Clicked += async (sende, e) => await Navigation.PushModalAsync(new CobaNavModal2());
		}
	}
}