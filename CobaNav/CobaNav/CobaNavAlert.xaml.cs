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
	public partial class CobaNavAlert : ContentPage
	{
		public CobaNavAlert ()
		{
			InitializeComponent ();
		}

        async void TampilkanAlertSimpel(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Ini adalah tampilan alert", "OK");
        }

        async void TampilkanAlertYaTidak(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Pertanyaan?", "Tutup alert ini", "Ya", "Tidak");
        }
    }
}