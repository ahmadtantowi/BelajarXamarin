using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CobaListView
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // CobaListView #1
            //MainPage = new CobaListView.CobaListViewBindingListString();

            // CobaListView #2
            //MainPage = new CobaListView.Views.ListItemPage();

            // CobaListView #3
            //MainPage = new CobaListView.Views.ListItemImageCell();

            // CobaListView #4
            MainPage = new CobaListView.Views.ListItemCustom();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
