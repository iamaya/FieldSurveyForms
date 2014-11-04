using FieldSurveyForms2.Models.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FieldSurveyForms2.Models;

namespace FieldSurveyForms2.DataAccess
{
    public class GetOffices
    {
        public GetOffices()
        {

        }
        public static string APIKey { get { return "ahWebsite"; } }
        public static string APIPwd { get { return "86rJw9s4xDAN2YzUCfz7+A=="; } }

        public static Uri BaseUri { get { return new Uri("http://ahphotoservice.azurewebsites.net/"); } }
        public async Task<ManifestZonesPagedViewModel> InvokeAPIAsync(string data)
        {
            var client = new HttpClient(
                    new HttpClientHandler
                    {
                        Credentials = new System.Net.NetworkCredential
                        {
                            UserName = APIKey,
                            Password = APIPwd
                        }
                    });

            client.BaseAddress = BaseUri;

            var response = await client.GetAsync("api/ManifestDetails/GetManifestDetailsByRefUserId/1/20/48d71237-e8a1-453e-9694-1384691f7a02!!System%20Administrator!!ALL!!37/dump");

            var returnJson = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<ManifestZonesPagedViewModel>(returnJson);
        }
    }
}
