using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldSurveyForms2.Models.ViewModels.SimplifiedViewModels
{
    public class OfficePageManifestDetails
    {
        public OfficePageManifestDetails()
        {

        }

        public int ID { get; set; }
        public int IDAccount { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }

    }
}
