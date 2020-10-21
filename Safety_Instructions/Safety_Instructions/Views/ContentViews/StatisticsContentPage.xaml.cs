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
    [DesignTimeVisible(true)]
    public partial class StatisticsContentPage : ContentView
    {

        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(StatisticsContentPage), string.Empty);
        public static readonly BindableProperty CountProperty = BindableProperty.Create(nameof(Count), typeof(int), typeof(StatisticsContentPage),0);

        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(StatisticsContentPage), default(ImageSource));

        public string Title
        {
            get => (string)GetValue(StatisticsContentPage.CardTitleProperty);
            set => SetValue(StatisticsContentPage.CardTitleProperty, value);
        }

        public int Count
        {
            get => (int)GetValue(StatisticsContentPage.CountProperty);
            set => SetValue(StatisticsContentPage.CountProperty, value);
        }

   

        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(StatisticsContentPage.IconImageSourceProperty);
            set => SetValue(StatisticsContentPage.IconImageSourceProperty, value);
        }

 
        public StatisticsContentPage()
        {
            InitializeComponent();
          
        }
    }
}