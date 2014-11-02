using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class Message
    {
        public Message()
        {
            this.MessageDetails = new List<MessageDetail>();
        }

        public int ID { get; set; }
        
        public string Subject { get; set; }
        public string Body { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public Nullable<int> ID_Pictures { get; set; }
        public AspNetUser AspNetUser1 { get; set; }
        public AspNetUser AspNetUser { get; set; }
        public Picture Picture { get; set; }
        public ICollection<MessageDetail> MessageDetails { get; set; }
    }
}
