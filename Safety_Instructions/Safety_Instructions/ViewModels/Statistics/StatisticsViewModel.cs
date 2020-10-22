using Safety_app.Helpers;
using Safety_Instructions.Data.APIConnections;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;
using Safety_Instructions.Helpers;
using System;
using Xamarin.Essentials;

namespace Safety_Instructions.ViewModels.Statistics
{
    public class StatisticsViewModel : BaseViewModel
    {
        public CoronaApiResult CoronaApiResult { get; set; }
        public StatisticsViewModel()
        {
          
        }

        public async System.Threading.Tasks.Task loadresultAsync()
        {
            CoronaApiResult coronaApi;
            if (CheckForInternet())
            {
                IRestservices restservice = new RestAPI(CommonValues.healhAPI);
                coronaApi = await restservice.MakeGetRequest();
                if (coronaApi == null)
                {
                    StaticFunctions.DisplayAlert_ProvideInformationAsync("Information", "Provblem in fetching Real time data");
                    coronaApi = await new Data.APIConnections.FileHandler().ReadAPIResultAsync();
                }
            }
            else
            {
                StaticFunctions.DisplayAlert_ProvideInformationAsync("Information", "No Active Internet Connection Detected.");
                coronaApi = await new Data.APIConnections.FileHandler().ReadAPIResultAsync();
            }
        
 
          
       
            CoronaApiResult = coronaApi;
        }

        private bool CheckForInternet()
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                return true;
            }
            return false;
        }
    }
}
