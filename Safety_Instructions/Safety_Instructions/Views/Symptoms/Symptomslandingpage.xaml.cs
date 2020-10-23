using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.Symptoms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Symptomslandingpage : ContentPage
    {
        public Symptomslandingpage()
        {
            InitializeComponent();
        }

        private async void animationView_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushModalAsync(new SymptomsPage());
        }
    }
}