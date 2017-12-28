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
	public partial class CobaNavHierarchy2 : ContentPage
	{
		public CobaNavHierarchy2 ()
		{
			InitializeComponent ();

            btnHalSatu.Clicked += async (sender, e) => await Navigation.PopAsync();
		}

        public CobaNavHierarchy2(string nama)
        {
            InitializeComponent();

            // CobaNav #6
            //lblNama.Text = "Nama Anda: " + nama;

            btnHalSatu.Clicked += async (sender, e) => await Navigation.PopAsync();
        }
    }
}