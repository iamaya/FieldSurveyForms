using FieldSurveyForms2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FieldSurveyForms2.Models;

namespace FieldSurveyForms2.Views
{
    public class OfficePage:ContentPage
    {
        ListView listView;
        RelativeLayout layout;

        public OfficePage()
        {
            Label header = new Label
            {
                Text = "Offices",
                Font = Font.BoldSystemFontOfSize(35),
                HorizontalOptions = LayoutOptions.Center
            };

            listView = new ListView();
            listView.ItemTemplate = new DataTemplate(typeof(OfficeCells));

            var getOffices = new GetOffices();

            var result = Task.Factory.StartNew(() => getOffices.InvokeAPIAsync(""));
            try
            {
                listView.ItemsSource = result.Result.Result.manifestdetails;
            }
            catch (Exception ex)
            {
                throw;
            }

            layout = new RelativeLayout();
            layout.Children.Add(
                listView,
                xConstraint: Constraint.Constant(0),
                yConstraint: Constraint.Constant(0),
                widthConstraint: Constraint.RelativeToParent((parent) => { return parent.Width; }),
                heightConstraint: Constraint.RelativeToParent((parent) => { return parent.Height; }));
            
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { 
                    header,
                    layout
                }
            };

            Content = stack;
            Padding = new Thickness(40, 0, 0, 0);
        }
    }
}
