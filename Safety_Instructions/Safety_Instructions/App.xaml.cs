using Safety_Instructions.Data;
using Safety_Instructions.Data.Models;
using Safety_Instructions.Views.Profile;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Safety_Instructions
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            ChangeNavigationToFirsttimelauncher();

        }

        private void ChangeNavigationToFirsttimelauncher()
        {
            var firstLaunch = VersionTracking.IsFirstLaunchEver;
            if (firstLaunch)
            {
                MainPage = new ProfilePage();
            }
            else
            {
                MainPage = new AppShell();
            }

        }

        static DataContext database;

        public static DataContext Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataContext("https://testproj-f4c94.firebaseio.com/");
                }
                return database;
            }
        }
        protected override void OnStart()
        {
            //  insertdataAsync();

        }

        private async System.Threading.Tasks.Task insertdataAsync()
        {
            string json = null;
            try
            {

                var x = new Instruction() { Id = 0, AnimationJson = "WashHands.json", Title = "Keep safe", Description = "aerfbgsdfnhfn" };
                var y = new Symptoms() { Id = 0, AnimationJson = "cough.json", Title = "Cough", Description = "aerfbgsdfnhfn" };
                // await Database.GetData_Instructions().Insert(x);
                await Database.GetData_Symptoms().Insert(y);
            }
            catch (Exception ex)
            {

                throw;
            }

        }










        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
