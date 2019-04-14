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

        private async void DownloadsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Downloads());
        }

        private async void MembershipButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MembershipKit());
        }

        private async void DiscountsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Discounts());
        }
    }
}