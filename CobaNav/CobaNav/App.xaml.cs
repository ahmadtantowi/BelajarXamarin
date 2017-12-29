using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CobaNav
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // CobaNav #1
            MainPage = new NavigationPage(new CobaNavHierarchy1());

            // CobaNav #2
            //MainPage = new NavigationPage(new CobaNavMenu());

            // CobaNav #3
            //MainPage = new CobaNavModal1();

            // CobaNav #4
            //MainPage = new CobaNavTab();

            // CobaNav #5
            //MainPage = new CobaNavPopupAlert();

            // CobaNav #6
            //MainPage = new MainPage();

            // CobaNav #7
            //MainPage = new NavigationPage(new CobaNavHierarchy1());

            // CobaNav #8
            Application.Current.Properties["id"] = "1147050013";
            //MainPage = new CobaNavModal1();
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
