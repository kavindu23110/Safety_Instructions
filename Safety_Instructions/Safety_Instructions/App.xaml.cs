using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Safety_Instructions.Services;
using Safety_Instructions.Views;
using Safety_Instructions.Views.Home;

namespace Safety_Instructions
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
