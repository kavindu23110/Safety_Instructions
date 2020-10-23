using System.Collections.ObjectModel;
using System.Linq;

namespace Safety_Instructions.ViewModels.Instructions
{
    public class InstructionsViewModel : BaseViewModel
    {
        public ObservableCollection<Data.Models.Instruction> lstInstructions { get; set; }

        internal void loadresult()
        {
            var ins = App.Database.GetData_Instructions().GetAsync();
            lstInstructions = new ObservableCollection<Data.Models.Instruction>(ins.OrderBy(p => p.Id));
        }
    }
}
