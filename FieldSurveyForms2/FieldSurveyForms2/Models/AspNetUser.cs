using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            this.AspNetUserClaims = new List<AspNetUserClaim>();
            this.AspNetUserLogins = new List<AspNetUserLogin>();
            this.ManifestDetails = new List<ManifestDetail>();
            this.Manifest_ServiceZone = new List<Manifest_ServiceZone>();
            this.Messages = new List<Message>();
            this.MessageDetails = new List<MessageDetail>();
            this.AspNetRoles = new List<AspNetRole>();
        }

        public string Id { get; set; }
        public string AHInternalID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Nullable<bool> IsProvisioned { get; set; }
        public string ID_AHAdmin { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string Email { get; set; }
        public Nullable<bool> EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> PhoneNumberConfirmed { get; set; }
        public Nullable<bool> TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public Nullable<bool> LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
        public Nullable<int> LoginAttemptCount { get; set; }
        public Nullable<System.DateTime> ReactivationTime { get; set; }
        public Nullable<System.DateTime> LoginAttemptStartTime { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Fax { get; set; }
        public ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public ICollection<ManifestDetail> ManifestDetails { get; set; }
        public ICollection<Manifest_ServiceZone> Manifest_ServiceZone { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<Message> Messages1 { get; set; }
        public ICollection<MessageDetail> MessageDetails { get; set; }
        public ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}
