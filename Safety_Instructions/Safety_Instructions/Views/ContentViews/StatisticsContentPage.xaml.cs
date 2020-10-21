using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticsContentPage : ContentView,INotifyPropertyChanged
    {

        public static readonly BindableProperty Iconproperty = BindableProperty.Create(
    "Icons",
    typeof(string),
    typeof(StatisticsContentPage),
    string.Empty);

        public static readonly BindableProperty titleproperty = BindableProperty.Create(
"Titles",
typeof(string),
typeof(Label),
string.Empty);

        public static readonly BindableProperty StaticNumberproperty = BindableProperty.Create(
"StaticNumbers",
typeof(string),
typeof(Label),
string.Empty);

        public string ImageSource
        {
            get => (string)GetValue(StatisticsContentPage.Iconproperty);
            set => SetValue(StatisticsContentPage.Iconproperty, value);
        }

        public string TitleText
        {
            get => (string)GetValue(StatisticsContentPage.titleproperty);
            set => SetValue(StatisticsContentPage.titleproperty, value);
        } 
        
        public string Count
        {
            get => (string)GetValue(StatisticsContentPage.StaticNumberproperty);
            set => SetValue(StatisticsContentPage.StaticNumberproperty, value);
        }
        public StatisticsContentPage()
        {
            InitializeComponent();
          
        }
    }
}