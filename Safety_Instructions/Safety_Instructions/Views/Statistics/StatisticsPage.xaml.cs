
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.Statistics
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticsPage : CarouselPage
    {
        public StatisticsPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Statistics.StatisticsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            load();
        }

        private async void load()
        {
            await (this.BindingContext as ViewModels.Statistics.StatisticsViewModel).loadresultAsync();
        }
    }
}