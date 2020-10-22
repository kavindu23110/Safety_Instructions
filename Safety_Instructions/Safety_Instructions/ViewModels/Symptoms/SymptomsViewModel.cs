using System.Collections.ObjectModel;

namespace Safety_Instructions.ViewModels.Symptoms
{
    public class SymptomsViewModel:BaseViewModel
    {

        public ObservableCollection<Data.Models.Symptoms> lstSymptoms { get; set; }
        public SymptomsViewModel()
        {

            LoadInstructionsAsync();

        }


        private async System.Threading.Tasks.Task LoadInstructionsAsync()
        {
            var ins = await App.Database.GetData_Symptoms().GetAsync();
            lstSymptoms = new ObservableCollection<Data.Models.Symptoms>(ins);
        }
    }
}