using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}