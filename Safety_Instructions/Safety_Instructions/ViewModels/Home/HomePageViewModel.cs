using Safety_Instructions.Views.EmergencyDialer;
using Safety_Instructions.Views.Statistics;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Safety_Instructions.ViewModels.Home
{
    public class HomePageViewModel : BaseViewModel
    {
        public ICommand InstructionsLandingCommand { get; set; }
        public ICommand SyntomsLandingCommand { get; set; }
        public ICommand StatisticsCommand { get; set; }
        public ICommand EmergencyDialCommand { get; set; }
        public ICommand linksCommand { get; set; }


        public ObservableCollection<Models.Navigations> lstNavigation { get; set; }
        public HomePageViewModel()
        {

            InstructionsLandingCommand = new Command(OnInstructionsLanding);
            SyntomsLandingCommand = new Command(OnSyntomsLanding);
            StatisticsCommand = new Command(OnStatistics);
            EmergencyDialCommand = new Command(OnEmergencyDial);
            linksCommand = new Command(Onlinks);




        }

        private async void OnStatistics(object obj)
        {
            await Shell.Current.Navigation.PushAsync(new Views.Statistics.StatisticsPage());
        }

        private async void OnEmergencyDial(object obj)
        {
            await Shell.Current.GoToAsync(nameof(Views.EmergencyDialer.EmergencyDialer));
        }

        private async void Onlinks(object obj)
        {
           // await Shell.Current.Navigation.PushAsync(new EmergencyDialer());
        }

        private async void OnSyntomsLanding(object obj)
        {
            await Shell.Current.Navigation.PushAsync(new Views.Symptoms.Symptomslandingpage());
        }

        private async void OnInstructionsLanding(object obj)
        {
            await Shell.Current.Navigation.PushAsync(new Views.Instructions.InstructionsLandingPage()); ;
        }
    }
}
