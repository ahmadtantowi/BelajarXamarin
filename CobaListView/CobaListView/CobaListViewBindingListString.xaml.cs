using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CobaListView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CobaListViewBindingListString : ContentPage
	{
		public CobaListViewBindingListString ()
		{
			InitializeComponent ();

            List<string> items = new List<string> { "Pertama", "Kedua", "Ketiga" };
            listView.ItemsSource = items;

            // untuk mengambil nilai dari item yang dipilih
            listView.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("Tapped", e.Item.ToString() + " telah dipilih", "OK");
                ((ListView)sender).SelectedItem = null;
            };
		}
	}
}