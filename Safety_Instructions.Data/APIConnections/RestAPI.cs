using Newtonsoft.Json;
using Safety_Instructions.Data.Interfaces;
using Safety_Instructions.Data.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.APIConnections
{
    public class RestAPI : IRestservices
    {
        public HttpClient _client { get; set; }
        public RestAPI(String URI)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(URI);
        }



        public async Task<CoronaApiResult> MakeGetRequest(string resource = null)
        {
            try
            {
                Uri uri;

                if (resource != null)
                {
                    uri = new Uri(_client.BaseAddress, resource);
                }
                else
                {
                    uri = _client.BaseAddress;
                }
                var request = new HttpRequestMessage()
                {

                    RequestUri = uri,
                    Method = HttpMethod.Get,
                };

                using (var response = await _client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<CoronaApiResult>(content);
                    await new FileHandler().SaveAPIResultToFile(obj);
                    return obj;
                }



            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
