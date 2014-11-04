using System;
using FieldSurveyForms2.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace FieldSurveyForms2
{
	public class GetProductStatus
	{
		public GetProductStatus ()
		{
		}

		public static string APIKey { get { return "ahWebsite"; } }
		public static string APIPwd { get { return "86rJw9s4xDAN2YzUCfz7+A=="; } }

		public static Uri BaseUri { get { return new Uri("http://ahphotoservice.azurewebsites.net/"); } }
		public async Task<ProductStatu> InvokeAPIAsync(string data)
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

			var response = await client.GetAsync("api/VisitStatu/GetProductStatus");

			var returnJson = response.Content.ReadAsStringAsync().Result;
			return JsonConvert.DeserializeObject<ProductStatu>(returnJson);
		}
	}
}

