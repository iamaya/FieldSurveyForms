using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            this.AspNetUsers = new List<AspNetUser>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Order { get; set; }
        public string Discriminator { get; set; }
        public ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
