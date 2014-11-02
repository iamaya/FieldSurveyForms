using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidApplication1
{
    [Activity(Label = "AndroidApplication1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        Button button2;
        Button button3;
        EditText editText1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
           // Button button = FindViewById<Button>(Resource.Id.MyButton);

           // button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            editText1 = FindViewById<EditText>(Resource.Id.editText1);

            button2 = FindViewById<Button>(Resource.Id.button2);
            button3 = FindViewById<Button>(Resource.Id.button3);

            button2.Click += button2_Click;
            button3.Click += button3_Click;
        }

        void button3_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("tel:8134561234");

            var intent = new Intent(Intent.ActionView, uri);

            StartActivity(intent);

            // StartActivity(typeof(SecondActivity));
        }

        void button2_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(SecondActivity));

            intent.PutExtra("Main", editText1.Text);

            StartActivity(intent);
        }
    }
}

