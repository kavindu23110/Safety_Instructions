using Safety_Instructions.Views.EmergencyDialer;
using Safety_Instructions.Views.Statistics;
using System;
using Xamarin.Forms;

namespace Safety_Instructions
{
    public partial class AppShell : Xamarin.Forms.Shell
    {

        public AppShell()
        {
            InitializeComponent();


            Routing.RegisterRoute(nameof(EmergencyDialer), typeof(EmergencyDialer));
            Routing.RegisterRoute(nameof(StatisticsPage), typeof(StatisticsPage));
        }


        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {

            await Shell.Current.Navigation.PushAsync(new EmergencyDialer());
        }
    }
}
