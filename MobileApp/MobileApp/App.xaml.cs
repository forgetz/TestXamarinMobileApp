using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using MobileApp.View;

namespace MobileApp
{
	public partial class App : Application
	{
        public static MobileServiceClient MobileService = new MobileServiceClient("https://forgetz.azurewebsites.net/");

		public App ()
		{
			InitializeComponent();

            var np = new NavigationPage(new CatalogPage());

            MainPage = np;
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
