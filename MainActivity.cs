using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Bethanys
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]//starting point/starting page when launched 
    public class MainActivity : AppCompatActivity
    {

        //on create is invoked automatically. upon creation of the activity 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);//this view/Activity relationship happens at run time so you have to specify 
            Button myButton = FindViewById<Button>(Resource.Id.MyButton);// it searches for for a generic type in the Resource.id...
            myButton.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, System.EventArgs e)
        {
            var toast = Toast.
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}