using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class APISecurity
    {
        public int ID { get; set; }
        public string APIUser { get; set; }
        public string APIKey { get; set; }
    }
}
