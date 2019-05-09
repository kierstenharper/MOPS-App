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
	public partial class LoginPageEmail : ContentPage
	{
		public LoginPageEmail ()
		{
			InitializeComponent ();
		}

        //Function called when login button is tapped.
        private async void LoginButtonTapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage());
        }

        //Function called when "Not A Member?" label tapped
        private void OnNotMemberGestureTap(object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("https://www.mops.org/myaccount/membership.php"));
        }
    }
}