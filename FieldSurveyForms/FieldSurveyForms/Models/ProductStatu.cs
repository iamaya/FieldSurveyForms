using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class ProductStatu
    {
        public ProductStatu()
        {
            this.ProductDetails = new List<ProductDetail>();
        }

        public int ID { get; set; }
        public string Status { get; set; }
        public int ID_ServiceTypes { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
