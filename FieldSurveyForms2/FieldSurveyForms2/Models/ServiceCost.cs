using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class ServiceCost
    {
        public ServiceCost()
        {
            this.ProductDetails = new List<ProductDetail>();
        }

        public int ID { get; set; }
        public int ID_ManifestMaster { get; set; }
        public int ID_ServiceZone { get; set; }
        public int ID_ServiceType { get; set; }
        public decimal Cost { get; set; }
        public ManifestMaster ManifestMaster { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ServiceType ServiceType { get; set; }
        public ServiceZone ServiceZone { get; set; }
    }
}
