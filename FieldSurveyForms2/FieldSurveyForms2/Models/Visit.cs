using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class Visit
    {
        public int ID { get; set; }
        public int ID_ManifestDetail { get; set; }
        public Nullable<int> Revisit_ID_ProductDetail { get; set; }
        public System.DateTime DateVisit { get; set; }
        public string Comments { get; set; }
        public string Signature { get; set; }
        public int ID_Status { get; set; }

        public Nullable<bool> IsRevisit { get; set; }
        public ManifestDetail ManifestDetail { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public Status Status { get; set; }
    }
}
