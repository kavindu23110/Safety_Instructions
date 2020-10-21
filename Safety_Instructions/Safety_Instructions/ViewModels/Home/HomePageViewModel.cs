using Safety_Instructions.BOD;
using Safety_Instructions.Helpers;
using Safety_Instructions.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Safety_Instructions.ViewModels.Home
{
    public class HomePageViewModel : BaseViewModel
    {
        public string MyProperty { get; set; }
        public ObservableCollection<Models.Navigations> lstNavigation { get; set; }
        public HomePageViewModel()
        {
            MyProperty = "Safe.json";
            lstNavigation = new ObservableCollection<Models.Navigations>
                (StateManager.GetProperties<List<Navigations>>(KeyValueDefinitions.Lstnavigation));
        }
    }
}
