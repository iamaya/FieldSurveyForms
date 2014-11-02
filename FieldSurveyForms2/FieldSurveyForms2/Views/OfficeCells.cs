using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldSurveyForms2.Views
{
    public class OfficeCells : ViewCell
    {
        public OfficeCells()
        {
            var labelCompany = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelCompany.SetBinding(Label.TextProperty, "Company");

            var labelOfficeId = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelOfficeId.SetBinding(Label.TextProperty, "IDAccount");

            var labelAddress1 = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelAddress1.SetBinding(Label.TextProperty, "Address1");

            var labelAddress2 = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelAddress2.SetBinding(Label.TextProperty, "Address2");

            var labelCity = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelCity.SetBinding(Label.TextProperty, "City");

            var labelState = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelState.SetBinding(Label.TextProperty, "State");

            var labelPostalCode = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelPostalCode.SetBinding(Label.TextProperty, "PostalCode");

            var labelContactFirstName = new Label
            {
                YAlign = TextAlignment.Center
            };

            labelContactFirstName.SetBinding(Label.TextProperty, "ContactFirstName");

            var labelContactLastName = new Label
             {
                 YAlign = TextAlignment.Center
             };

            labelContactLastName.SetBinding(Label.TextProperty, "ContactLastName");

            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { 
                    labelCompany,
                    labelOfficeId,
                    labelAddress1,
                    labelAddress2,
                new StackLayout {
                Orientation=StackOrientation.Horizontal,
                Children={
                    labelCity,
                    labelState,
                    labelPostalCode
                }
                },
                
                new StackLayout {
                Orientation=StackOrientation.Horizontal,
                Children={
                    labelContactFirstName,
                    labelContactLastName
                }
                }
                }
            };
        }
    }
}
