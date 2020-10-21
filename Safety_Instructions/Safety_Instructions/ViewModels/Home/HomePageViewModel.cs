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
        public ICommand StatisticsCommandCommand { get; set; }
        public ICommand EmergencyDialCommand { get; set; }
        public ICommand linksCommand { get; set; }


        public ObservableCollection<Models.Navigations> lstNavigation { get; set; }
        public HomePageViewModel()
        {

            InstructionsLandingCommand = new Command(OnInstructionsLanding);
            SyntomsLandingCommand = new Command(OnSyntomsLanding);
            StatisticsCommandCommand = new Command(OnStatistics);
            EmergencyDialCommand = new Command(OnEmergencyDial);
            linksCommand = new Command(Onlinks);




        }

        private void OnStatistics(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnEmergencyDial(object obj)
        {
            throw new NotImplementedException();
        }

        private void Onlinks(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnSyntomsLanding(object obj)
        {
            throw new NotImplementedException();
        }

        private void OnInstructionsLanding(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
