using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class AspNetUserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }
        public AspNetUser AspNetUser { get; set; }
    }
}
