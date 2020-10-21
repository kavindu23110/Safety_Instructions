using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.Instructions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstructionsLandingPage : ContentPage
    {
        public InstructionsLandingPage()
        {
            InitializeComponent();
        }

        private async void animationView_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushModalAsync(new InstructionsPage());
        }

    }
}