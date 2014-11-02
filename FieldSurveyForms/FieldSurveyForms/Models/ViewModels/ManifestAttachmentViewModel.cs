using FieldSurveyForms;
using FieldSurveyForms.Models;
using FieldSurveyForms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FieldSurveyForms.Models.ViewModels
{
    public class ManifestAttachmentViewModel
    {
        public List<ManifestAttachment> manifestAttachments { get; set; }

        public List<ManifestProductDetailsViewModel> ManifestProductDetailsViewModel { get; set; }

        public List<ManifestProductInvoiceViewModel> ManifestProductInvoiceViewModel { get; set; }

        public string Month { get; set; }
        public int Year { get; set; }

        public string techid { get; set; }
        public string depot { get; set; }

        public int productcount { get; set; }
        public int productcountcompleted { get; set; }

        public string Name { get; set; }
        public string Company { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
    }

    public class ManifestProductDetailsViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public int productCompleCout { get; set; }
    }

    public class ManifestProductInvoiceViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal cost { get; set; }
        public int quantity { get; set; }
        public int Actualquantity { get; set; }
        public decimal total { get; set; }
        public int visit { get; set; }
        public int visitcount { get; set; }
        public int BonusGroup { get; set; }
        public int ID_SVCZone { get; set; }
    }
}