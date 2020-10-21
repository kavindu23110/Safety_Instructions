using System.Collections.ObjectModel;

namespace Safety_Instructions.ViewModels.Instructions
{
    public class InstructionsViewModel : BaseViewModel
    {
        public ObservableCollection<Data.Models.Instruction> lstInstructions { get; set; }
        public InstructionsViewModel()
        {
            LoadInstructionsAsync();
        }

        private async System.Threading.Tasks.Task LoadInstructionsAsync()
        {
            var ins = await App.Database.GetData_Instructions().GetAsync();
            lstInstructions = new ObservableCollection<Data.Models.Instruction>(ins);
        }
    }
}
