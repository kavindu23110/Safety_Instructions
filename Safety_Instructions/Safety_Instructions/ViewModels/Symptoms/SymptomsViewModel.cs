using System;
using System.Collections.Generic;
using System.Text;

namespace Safety_Instructions.ViewModels.Symptoms
{
  public  class SymptomsViewModel
    {
    }


    private async System.Threading.Tasks.Task LoadInstructionsAsync()
    {
        var ins = await App.Database.GetData_Instructions().GetAsync();
        lstInstructions = new ObservableCollection<Data.Models.Symptoms>(ins);
    }
}
