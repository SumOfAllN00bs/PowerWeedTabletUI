using Android.App;
using Android.Widget;
using Android.OS;

namespace PowerWeedTabletUI
{
    [Activity(Label = "PowerWeedTabletUI", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class MainActivity : Activity
    {
        ImageView img_DashboardLogo;
        Button btn_AssignJobs;
        Button btn_EditEmployee;
        Button btn_ViewPlan;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Dashboard_Tablet);
            img_DashboardLogo = FindViewById<ImageView>(Resource.Id.img_DashboardLogo);
            btn_AssignJobs = FindViewById<Button>(Resource.Id.btn_Assign);
            btn_EditEmployee = FindViewById<Button>(Resource.Id.btn_EditEmployees);
            btn_ViewPlan = FindViewById<Button>(Resource.Id.btn_ViewPlan);

            btn_AssignJobs.Click += Btn_AssignJobs_Click;
            btn_EditEmployee.Click += Btn_EditEmployee_Click;
            btn_ViewPlan.Click += Btn_ViewPlan_Click;
        }

        private void Btn_ViewPlan_Click(object sender, System.EventArgs e)
        {
            //StartActivity(typeof(/));
        }

        private void Btn_EditEmployee_Click(object sender, System.EventArgs e)
        {
            //StartActivity(typeof(/));
        }

        private void Btn_AssignJobs_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(AddJob_Tablet_Activity));
        }

        protected override void OnResume()
        {
            base.OnResume();
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Landscape;
        }
    }
}

