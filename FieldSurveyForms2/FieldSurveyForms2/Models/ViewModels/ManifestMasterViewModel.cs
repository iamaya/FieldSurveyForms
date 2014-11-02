using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldSurveyForms2.Models.ViewModels
{
    public class ManifestMasterViewModel
    {
        public int Id { get; set; }
        public int Id_ManifestMaster { get; set; }
        public Nullable<int> Id_Status { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserId { get; set; }
        public int Id_ServiceZone { get; set; }
        public string manifeststatus { get; set; }
        public string ServiceZone_Name { get; set; }
        
        public int totalOfficeCount { get; set; }
        public int totalVisitCount { get; set; }

    }
}
