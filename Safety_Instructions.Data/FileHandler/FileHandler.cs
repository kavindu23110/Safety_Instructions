using Newtonsoft.Json;
using Safety_Instructions.Data.Models;
using System.IO;
using System.Threading.Tasks;

namespace Safety_Instructions.Data.APIConnections
{
    public class FileHandler
    {
        public async Task SaveAPIResultToFile(CoronaApiResult apiResult)
        {
            try
            {
                var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Corona.txt");

                using (var writer = File.CreateText(backingFile))
                {
                    await writer.WriteLineAsync(JsonConvert.SerializeObject(apiResult));
                }
            }
            catch (System.Exception d)
            {

                throw;
            }
        }

        public async Task<CoronaApiResult> ReadAPIResultAsync()
        {
            var backingFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Corona.txt");

            if (backingFile == null || !File.Exists(backingFile))
            {
                return null;
            }

            CoronaApiResult apiResult = null;
            using (var reader = new StreamReader(backingFile, true))
            {
                string result = await reader.ReadToEndAsync();
                apiResult = JsonConvert.DeserializeObject<CoronaApiResult>(result);

                return apiResult;
            }
        }

    }
}
