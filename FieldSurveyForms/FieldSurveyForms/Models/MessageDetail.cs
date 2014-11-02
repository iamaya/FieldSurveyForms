using System;
using System.Collections.Generic;

namespace FieldSurveyForms.Models
{
    public partial class MessageDetail
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public int MsgID { get; set; }
        public Nullable<System.DateTime> ReadDate { get; set; }
        public bool IsNew { get; set; }
        public bool IsDelete { get; set; }
        public AspNetUser AspNetUser { get; set; }
        public Message Message { get; set; }
    }
}
