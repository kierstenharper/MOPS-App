using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThisMonth : ContentPage
	{
		public ThisMonth ()
		{
			InitializeComponent ();
		}

        //Function called when hamburgermenu is tapped.
        private async void OnHamburgerMenuGestureTap(object sender, EventArgs args)
        {
            //temp code until I get some sort of dropdown working
            await Navigation.PushModalAsync(new Videos());
        }
    }
}