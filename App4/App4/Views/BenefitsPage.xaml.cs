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
	public partial class BenefitsPage : ContentPage
	{
		public BenefitsPage ()
		{
			InitializeComponent ();
		}

        //Function called when downloads button is tapped.
        private async void DownloadsButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Downloads());
        }

        //Function called when membership button is tapped.
        private async void MembershipButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MembershipKit());
        }

        //Function called when discounts is tapped.
        private async void DiscountsButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Discounts());
        }

        //Function called when hamburgermenu is tapped.
        private async void OnHamburgerMenuGestureTap(object sender, EventArgs args)
        {
            //temp code until I get some sort of dropdown working
            await Navigation.PushModalAsync(new Downloads());
        }
    }
}