using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Safety_Instructions.ViewModels.Symptoms
{
    public class SymptomsViewModel
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