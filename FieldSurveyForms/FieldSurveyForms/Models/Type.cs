using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class Type
    {
        public Type()
        {
            this.Status = new List<Status>();
        }

        public int ID { get; set; }
        public string Type1 { get; set; }
        public ICollection<Status> Status { get; set; }
    }
}
