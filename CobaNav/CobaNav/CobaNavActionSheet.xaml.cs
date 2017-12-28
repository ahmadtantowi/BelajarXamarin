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
	public partial class CobaNavActionSheet : ContentPage
	{
		public CobaNavActionSheet ()
		{
			InitializeComponent ();
		}

        async void TampilkanActionSheetSimpel(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Bagikan ke?", "Batal", null, "Email", "Twitter", "Facebook");
        }

        async void TampilkanActionSheetHapusBatal(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Siman Gambar?", "Batal", "Hapus", "Photo Roll", "Favorites");
        }
    }
}