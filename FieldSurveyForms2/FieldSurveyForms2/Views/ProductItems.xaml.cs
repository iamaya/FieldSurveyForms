using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FieldSurveyForms2.Views
{
	public partial class ProductItems : ContentView
	{
		public ProductItems ()
		{
			InitializeComponent ();
		}
	}


    public class ProductCell : ViewCell
    {
        public ProductCell()
        {
            View = new ProductItems();
        }
    }
}

