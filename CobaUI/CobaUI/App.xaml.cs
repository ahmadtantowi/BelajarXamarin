using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CobaUI
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // CobaUI #1
            //MainPage = new CobaUI.CobaUIStackLayout();

            // CobaUI #2
            //MainPage = new CobaUI.CobaUIAbsoluteLayout();

            // CobaUI #3
            //MainPage = new CobaUI.CobaUIRelativeLayout();

            // CobaUI #4
            //MainPage = new CobaUI.CobaUIGridLayout();

            // CobaUI #5
            MainPage = new CobaUI.CobaUIBuatKalkulator();
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
