using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidApplication1
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        TextView text;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Second);

            text = FindViewById<TextView>(Resource.Id.textView1);

            text.Text = Intent.GetStringExtra("Main") ?? "NULL";

            // Create your application here
        }
    }
}