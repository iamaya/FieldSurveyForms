using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class Picture
    {
        public Picture()
        {
            this.Messages = new List<Message>();
        }

        public int ID { get; set; }
        public string Picture_Location { get; set; }
        public Nullable<int> ID_ProductDetails { get; set; }
        public string Picture_Metadata { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
