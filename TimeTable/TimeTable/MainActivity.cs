using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace TimeTable
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var btnMonday = FindViewById<Button>(Resource.Id.btnMonday);
            btnMonday.Click += BtnMonday_Click;
        }
        private void BtnMonday_Click(object sender, System.EventArgs e)
        {
            FindViewById<TextView>(Resource.Id.MonClass).Text = "8am-10am | Interface Analysis & Design | 10am-12pm | Programming";
        }

    }
}