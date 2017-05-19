using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CatalogPage : ContentPage
	{
		public CatalogPage ()
		{
			InitializeComponent();

            BindingContext = new CatalogViewModel();
		}

        private void Add_Clicked(object sender, EventArgs e)
        {

        }
    }
}
