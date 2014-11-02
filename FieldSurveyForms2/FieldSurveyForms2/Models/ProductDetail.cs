using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class ProductDetail
    {
        public ProductDetail()
        {
            this.Pictures = new List<Picture>();
            this.Visits = new List<Visit>();
        }

        public int ID { get; set; }
        public int ID_Product { get; set; }
        public int ID_ManifestDetail { get; set; }
        public Nullable<int> ID_PlacementStatus { get; set; }
        public string Barcode { get; set; }
        public string Comments { get; set; }
        public Nullable<int> ID_Status { get; set; }
        public int ID_ServiceCost { get; set; }
        public Nullable<int> ID_ProductStatus { get; set; }
        public ManifestDetail ManifestDetail { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public Product Product { get; set; }
        public ServiceCost ServiceCost { get; set; }
        public Status Status { get; set; }
        public Status Status1 { get; set; }
        public ProductStatu ProductStatu { get; set; }
        //public ProductDetail ProductDetails1 { get; set; }
        //public ProductDetail ProductDetail1 { get; set; }
        //public ProductDetail ProductDetails11 { get; set; }
        //public ProductDetail ProductDetail2 { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}
