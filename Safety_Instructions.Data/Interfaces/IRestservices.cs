using Safety_Instructions.Data.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.Interfaces
{
    public interface IRestservices
    {
        HttpClient _client { get; set; }
        Task<CoronaApiResult> MakeGetRequest(string resource);
    }
}
