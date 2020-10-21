using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Safety_Instructions.Services;
using Safety_Instructions.Views;
using Safety_Instructions.Views.Home;
using System.Collections.Generic;
using Safety_Instructions.Models;
using Safety_Instructions.Views.Instructions;
using Safety_Instructions.Data;
using System.IO;
using Safety_Instructions.Data.Models;
using Xamarin.Forms.PlatformConfiguration;
using Android.Graphics;
using Safety_Instructions.Views.Statistics;
using Safety_Instructions.Views.EmergencyDialer;
using Safety_Instructions.Views.Symptoms;

namespace Safety_Instructions
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new StatisticsPage();
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

                var x = new Instruction() { Id = 0, AnimationJson ="WashHands.json", Title = "Keep safe" ,Description="aerfbgsdfnhfn"};
                var y= new Symptoms() { Id = 0, AnimationJson = "cough.json", Title = "Cough", Description = "aerfbgsdfnhfn" };
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
