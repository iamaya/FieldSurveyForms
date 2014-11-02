using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class ManifestProduct
    {
        public int ID { get; set; }
        public int ID_Product { get; set; }
        public int ID_ManifestMaster { get; set; }
        public ManifestMaster ManifestMaster { get; set; }
        public Product Product { get; set; }
    }
}
