using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class ManifestDetail
    {
        public ManifestDetail()
        {
            this.ProductDetails = new List<ProductDetail>();
            this.TripPlans = new List<TripPlan>();
            this.Visits = new List<Visit>();
        }

        public int ID { get; set; }
        public int IDAccount { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string TechType { get; set; }
        public string NetworkType { get; set; }
        public string WRN_Status { get; set; }
        public Nullable<bool> Service_Required { get; set; }
        public Nullable<bool> Service_Performed { get; set; }
        public string HRS_Monday { get; set; }
        public string HRS_Tuesday { get; set; }
        public string HRS_Wednesday { get; set; }
        public string HRS_Thrusday { get; set; }
        public string HRS_Friday { get; set; }
        public string HRS_Saturday { get; set; }
        public string HRS_Sunday { get; set; }
        public int ID_SVCZone { get; set; }
        public string ID_AspNetUsers { get; set; }
        public int ID_ManifestMaster { get; set; }
        public Nullable<int> ID_Status { get; set; }
        public Nullable<int> ID_ServiceRequiredStatus { get; set; }
        public AspNetUser AspNetUser { get; set; }
        
        public ManifestMaster ManifestMaster { get; set; }
        public Status Status { get; set; }
        public Status Status1 { get; set; }
        public ServiceZone ServiceZone { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
        public ICollection<TripPlan> TripPlans { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}
