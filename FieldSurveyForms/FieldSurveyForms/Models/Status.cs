using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class Status
    {
        public Status()
        {
            this.Manifest_ServiceZone = new List<Manifest_ServiceZone>();
            this.ManifestDetails = new List<ManifestDetail>();
            this.ManifestDetails1 = new List<ManifestDetail>();
            this.ProductDetails = new List<ProductDetail>();
            this.ProductDetails1 = new List<ProductDetail>();
            this.Visits = new List<Visit>();
        }

        public int ID { get; set; }
        public string Status1 { get; set; }
        public int ID_Type { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public ICollection<Manifest_ServiceZone> Manifest_ServiceZone { get; set; }
        public ICollection<ManifestDetail> ManifestDetails { get; set; }
        public ICollection<ManifestDetail> ManifestDetails1 { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
        public ICollection<ProductDetail> ProductDetails1 { get; set; }
        public Type Type { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}
