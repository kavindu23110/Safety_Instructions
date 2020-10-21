using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.EmergencyDialer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmergencyDialer : ContentPage
    {
        public EmergencyDialer()
        {
            InitializeComponent();
            BindingContext = new ViewModels.EmergencyDialer.EmergencyDialerViewModel();
        }

        private void animationView_Clicked(object sender, EventArgs e)
        {

        }
    }
}