using System;
using System.Collections.Generic;

namespace FieldSurveyForms2.Models
{
	public class ManifestDetailViewModel
	{
		public ManifestDetail manifestdetail  { get; set; }

		//public HttpPostedFileBase picture { get; set; }
		public string comments { get; set; }

		//[Required]
		//[StringLength(100, ErrorMessage = "Please sign the visit by entering Name or Drawing")]
		public string output { get; set; }
		public string hdfield { get; set; }
		public string manifestName { get; set; }
		public string manifestDetailZone { get; set; }
		public ICollection<ServiceType> serviceType { get; set; }
		public ICollection<Status> vistStatus { get; set; }
		public ICollection<ProductStatu> productStatus { get; set; }
		public bool Is_Revisit { get; set; }


		//[DisplayFormat(DataFormatString = "{0:d}")]
		public Nullable<System.DateTime> Visit_Date { get; set; }
	}

}

