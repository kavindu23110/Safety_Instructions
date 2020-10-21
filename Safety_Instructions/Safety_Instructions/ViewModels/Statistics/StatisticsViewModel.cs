using Safety_Instructions.Data.APIConnections;
using Safety_Instructions.Data.Models;
using Safety_Instructions.Helpers;

namespace Safety_Instructions.ViewModels.Statistics
{
    public class StatisticsViewModel : BaseViewModel
    {
        public CoronaApiResult CoronaApiResult { get; set; }
        public StatisticsViewModel()
        {
            loadresultAsync();
        }

        private async System.Threading.Tasks.Task loadresultAsync()
        {
            var data = await new RestAPI(CommonValues.healhAPI).MakeGetRequest();
            if (data == null)
            {
                data = await new Data.APIConnections.FileHandler().ReadAPIResultAsync();
            }
            CoronaApiResult = data;
        }
    }
}
