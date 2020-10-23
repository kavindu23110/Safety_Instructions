using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.Instructions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstructionsPage : ContentPage
    {
        public ObservableCollection<string> ins { get; set; }

        public InstructionsPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Instructions.InstructionsViewModel();


            //TextAsync();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            load();
        }

        private async void load()
        {
            (this.BindingContext as ViewModels.Instructions.InstructionsViewModel).loadresult();
        }
    }
}