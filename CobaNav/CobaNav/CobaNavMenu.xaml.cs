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
	public partial class CobaNavMenu : ContentPage
	{
		public CobaNavMenu ()
		{
			InitializeComponent ();
		}

        protected async void Navigasikan(object sender, EventArgs args)
        {
            string type = (string)((ToolbarItem)sender).CommandParameter;
            Type pageType = Type.GetType("CobaNav." + type, true);
            Page page = (Page)Activator.CreateInstance(pageType);
            await this.Navigation.PushAsync(page);
        }
    }
}