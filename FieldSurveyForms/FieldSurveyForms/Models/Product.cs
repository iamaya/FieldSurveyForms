using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class Product
    {
        public Product()
        {
            this.ManifestProducts = new List<ManifestProduct>();
            this.ProductDetails = new List<ProductDetail>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> PlacementRequired { get; set; }
        public Nullable<bool> PictureRequired { get; set; }
        public Nullable<bool> BarCodeRequired { get; set; }
        public ICollection<ManifestProduct> ManifestProducts { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
