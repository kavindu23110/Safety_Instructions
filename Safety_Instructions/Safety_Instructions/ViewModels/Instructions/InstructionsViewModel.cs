using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Safety_Instructions.ViewModels.Instructions
{
    public class InstructionsViewModel : BaseViewModel
    {
        public ObservableCollection<Data.Models.Instruction> lstInstructions { get; set; }

        internal async Task loadresultAsync()
        {
            var ins = await App.Database.GetData_Instructions().GetAsync();
            lstInstructions = new ObservableCollection<Data.Models.Instruction>(ins.OrderBy(p => p.Id));
        }
    }
}
