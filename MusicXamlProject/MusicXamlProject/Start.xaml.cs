using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MusicXamlProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Start : ContentPage
	{
		public Start ()
		{
			InitializeComponent ();
		}

        private async void Button_ClickedStart(Object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new MainPage());
        }
	}
}