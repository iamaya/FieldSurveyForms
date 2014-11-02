using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldSurveyForms2.Views
{
    public class ManifestCells : ViewCell
    {
        public ManifestCells()
        {
            var labelDetailsZone = new Label
            {
                YAlign = TextAlignment.Center,
                Font = Font.BoldSystemFontOfSize(15)
            //    BackgroundColor = Color.Gray
            };

            labelDetailsZone.SetBinding(Label.TextProperty, "ServiceZone_Name");
            
            var labelFirstName = new Label
            {
                YAlign = TextAlignment.Center
                
            };
            labelFirstName.SetBinding(Label.TextProperty, "UserFirstName");

            var labelLastName = new Label
            {
                YAlign = TextAlignment.Center
            };
            labelLastName.SetBinding(Label.TextProperty, "UserLastName");

            var labelManifestStatus = new Label
            {
                YAlign = TextAlignment.Center
            };
            labelManifestStatus.SetBinding(Label.TextProperty, "manifeststatus");
            
            var namelayout = new StackLayout
            {
                //Padding = new Thickness(0, 0, 0, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { labelFirstName, labelLastName }
            };
            
            var mainlayout = new StackLayout
            {
                Padding = new Thickness(20,40,0,0),
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { labelDetailsZone, namelayout, labelManifestStatus}
            };


            
            View = mainlayout;
        }
    }
}
