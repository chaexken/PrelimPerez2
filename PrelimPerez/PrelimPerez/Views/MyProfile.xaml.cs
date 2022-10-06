using System;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace PrelimPerez.Views
{
    public partial class MyProfile : ContentPage
    {
        public MyProfile()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            // Launch the specified URL in the system browser.
            await Launcher.OpenAsync("https://www.facebook.com/chaexken/");
        }
    }
}