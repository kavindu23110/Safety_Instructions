using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Safety_Instructions.Services;
using Safety_Instructions.Views;

namespace Safety_Instructions
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
