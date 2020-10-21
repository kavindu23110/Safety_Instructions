
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.Symptoms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SymptomsPage : ContentPage
    {
        public SymptomsPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Symptoms.SymptomsViewModel();
        }
    }
}