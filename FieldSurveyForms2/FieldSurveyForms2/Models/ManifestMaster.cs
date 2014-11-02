using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class ManifestMaster
    {
        public ManifestMaster()
        {
            this.Manifest_ServiceZone = new List<Manifest_ServiceZone>();
            this.ManifestDetails = new List<ManifestDetail>();
            this.ManifestProducts = new List<ManifestProduct>();
            this.ServiceCosts = new List<ServiceCost>();
            this.TripPlans = new List<TripPlan>();
        }

        public int ID { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public ICollection<Manifest_ServiceZone> Manifest_ServiceZone { get; set; }
        public ICollection<ManifestDetail> ManifestDetails { get; set; }
        public ICollection<ManifestProduct> ManifestProducts { get; set; }
        public ICollection<ServiceCost> ServiceCosts { get; set; }
        public ICollection<TripPlan> TripPlans { get; set; }
    }
}
