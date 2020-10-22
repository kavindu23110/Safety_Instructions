using Safety_Instructions.Data;
using Safety_Instructions.Data.Database;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;
using Safety_Instructions.Views.Profile;
using System;
using System.IO;
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

        static IDatabase database;

        public static IDatabase Database
        {
            get
            {
                if (database == null)
                {

                    database = new Database("https://testproj-f4c94.firebaseio.com/");
                }
                return database;
            }
        }

    }
}
