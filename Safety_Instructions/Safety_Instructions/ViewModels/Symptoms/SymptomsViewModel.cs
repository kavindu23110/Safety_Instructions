using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Safety_Instructions.ViewModels.Symptoms
{
    public class SymptomsViewModel:BaseViewModel
    {

        public ObservableCollection<Data.Models.Symptoms> lstSymptoms { get; set; }




        internal void loadresult()
        {
            var ins = App.Database.GetData_Symptoms().GetAsync();
            lstSymptoms = new ObservableCollection<Data.Models.Symptoms>(ins.OrderBy(p => p.Id));
        }
    }
}