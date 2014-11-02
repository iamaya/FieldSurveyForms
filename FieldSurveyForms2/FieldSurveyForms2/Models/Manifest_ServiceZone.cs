using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
    public partial class Manifest_ServiceZone
    {
        public Manifest_ServiceZone()
        {
            this.ManifestAttachments = new List<ManifestAttachment>();
        }

        public int ID { get; set; }
        public int ID_ServiceZone { get; set; }
        public string ID_AspNetUser { get; set; }
        public int ID_MasterManifest { get; set; }
        public Nullable<int> ID_Status { get; set; }
        public AspNetUser AspNetUser { get; set; }
        public Status Status { get; set; }
        public ManifestMaster ManifestMaster { get; set; }
        public ServiceZone ServiceZone { get; set; }
        public ICollection<ManifestAttachment> ManifestAttachments { get; set; }

    }
}
