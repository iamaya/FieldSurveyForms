using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FieldSurveyForms2.DataAccess
{
   public class APIBase
    {
       public string APIKey { get { return "ahWebsite";} }
        public string APIPwd { get {return "86rJw9s4xDAN2YzUCfz7+A=="; } }

        public Uri BaseUri { get { return new Uri("http://ahphotoservice.azurewebsites.net/"); } }

        public System.Net.Http.HttpClient client { get {

            return new System.Net.Http.HttpClient(
                 new HttpClientHandler
                 {
                     Credentials = new System.Net.NetworkCredential
                     {
                         UserName = APIKey,
                         Password = APIPwd
                     }
                 });
        } }
    }
}
