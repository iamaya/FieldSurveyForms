using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class ServiceZone
    {
        public ServiceZone()
        {
            this.Manifest_ServiceZone = new List<Manifest_ServiceZone>();
            this.ManifestDetails = new List<ManifestDetail>();
            this.ServiceCosts = new List<ServiceCost>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int ID_Ext { get; set; }
        public ICollection<Manifest_ServiceZone> Manifest_ServiceZone { get; set; }
        public ICollection<ManifestDetail> ManifestDetails { get; set; }
        public ICollection<ServiceCost> ServiceCosts { get; set; }
    }
}
