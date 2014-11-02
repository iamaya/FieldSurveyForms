using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using FieldSurveyForms2.Views;

namespace FieldSurveyForms2
{
    public class App
    {
        public static Page GetMainPage()
        {
           return new OfficePage();

            //return new ManifestPage();
            //{
            //    Content = new Label
            //    {
            //        Text = "Hello, Forms !",
            //        VerticalOptions = LayoutOptions.CenterAndExpand,
            //        HorizontalOptions = LayoutOptions.CenterAndExpand,
            //    },
            //};
        }
    }
}
