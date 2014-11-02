using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class ManifestAttachment
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string Attachment { get; set; }
        public int ID_Manifest_ServiceZone { get; set; }
        public Manifest_ServiceZone Manifest_ServiceZone { get; set; }
    }
}
