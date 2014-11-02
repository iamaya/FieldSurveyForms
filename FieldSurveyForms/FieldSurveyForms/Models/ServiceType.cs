using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            this.ProductStatus = new List<ProductStatu>();
            this.ServiceCosts = new List<ServiceCost>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public int BonusGroup { get; set; }
        public ICollection<ProductStatu> ProductStatus { get; set; }
        public ICollection<ServiceCost> ServiceCosts { get; set; }
    }
}
