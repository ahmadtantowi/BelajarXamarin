using CobaListView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CobaListView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListItemCustom : ContentPage
	{
		public ListItemCustom ()
		{
			InitializeComponent ();
            // digunakan untuk mengarahkan sumber data yang akan ditampilkan pada halaman xaml.
            BindingContext = new ViewModels.ListItemViewModel();
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Judul.ToString() + " telah dipilih", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}