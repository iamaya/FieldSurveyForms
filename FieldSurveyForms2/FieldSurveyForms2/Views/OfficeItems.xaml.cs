using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FieldSurveyForms2.Views
{
    public partial class OfficeItems:ContentView
    {
        public OfficeItems()
        {
            InitializeComponent();
        }
    }

    public class OfficeCell : ViewCell
    {
        public OfficeCell()
        {
            View = new OfficeItems();
        }
    }
}
