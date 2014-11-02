using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class TripPlan
    {
        public int ID { get; set; }
        public int ID_ManifestMaster { get; set; }
        public int ID_ManifestDetails { get; set; }
        public int TripOrder { get; set; }
        public ManifestDetail ManifestDetail { get; set; }
        public ManifestMaster ManifestMaster { get; set; }
    }
}
