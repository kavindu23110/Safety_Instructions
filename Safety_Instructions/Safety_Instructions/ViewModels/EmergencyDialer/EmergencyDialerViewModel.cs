using Safety_app.Helpers;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Safety_Instructions.ViewModels.EmergencyDialer
{
    public class EmergencyDialerViewModel
    {
        public ICommand CallCommand { get; }
        public EmergencyDialerViewModel()
        {
            CallCommand = new Command(OnCallButtonPress);
        }

        private void OnCallButtonPress(object obj)
        {

            try
            {
                PhoneDialer.Open("1999");
            }
            catch (Exception Ex)
            {

                StaticFunctions.DisplayAlert_ProvideInformationAsync("Unable to Dial", "Please use another Device to Contact Covid Emergency Center");

            }
        }
    }
}
