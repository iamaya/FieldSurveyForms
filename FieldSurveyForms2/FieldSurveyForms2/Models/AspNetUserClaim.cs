using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class AspNetUserClaim
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public AspNetUser AspNetUser { get; set; }
    }
}
