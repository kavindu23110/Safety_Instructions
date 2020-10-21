using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Safety_Instructions.Views.Instructions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstructionsPage : ContentPage
    {
        public ObservableCollection<string >  ins{get;set;}
     
        public InstructionsPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Instructions.InstructionsViewModel();
         
        
            //TextAsync();
        }

        private async Task TextAsync()
        {
            var x =await App.Database.GetData_Instructions().GetAsync();
            //MyProperty = x.FirstOrDefault().AnimationJson;
           // MyProperty = x.FirstOrDefault().AnimationJson.Replace("\\", "");
           
        }
    }
}