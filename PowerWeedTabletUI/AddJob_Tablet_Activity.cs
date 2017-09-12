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
using PWBackend;
using Android.Graphics.Drawables;
using Android.Util;

namespace PowerWeedTabletUI
{
    [Activity(Label = "AddJob_Tablet_Activity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class AddJob_Tablet_Activity : Activity
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee() {empID = 0, empMobile=0123456789, empType="office", empNAME="charles barry", empPhone=0123456789},
            new Employee() {empID = 1, empMobile=0123456790, empType="laborer", empNAME="harry barnes", empPhone=0123456790},
            new Employee() {empID = 2, empMobile=0123456791, empType="driver", empNAME="kelly knowles", empPhone=0123456791},
            new Employee() {empID = 3, empMobile=0123456792, empType="laborer", empNAME="peter potter", empPhone=0123456792},
            new Employee() {empID = 4, empMobile=0123456793, empType="driver", empNAME="norman hughes", empPhone=0123456793},
            new Employee() {empID = 5, empMobile=0123456794, empType="staff", empNAME="sherry glass", empPhone=0123456794}
        };
        List<Job> jobs = new List<Job>()
        {
            new Job() { jobID = 0, jobName = "mowing" },
            new Job() { jobID = 1, jobName = "concrete pavement replacement" },
            new Job() { jobID = 2, jobName = "paper work" },
            new Job() { jobID = 3, jobName = "wood work" },
            new Job() { jobID = 4, jobName = "metal work" },
            new Job() { jobID = 5, jobName = "signs" },
            new Job() { jobID = 6, jobName = "managerial work" }
        };
        GridLayout gl_Jobs;
        ScrollView sv_Jobs;
        ListView lv_Employees;
        ViewGroup.LayoutParams lparam = new ViewGroup.LayoutParams(LinearLayout.LayoutParams.WrapContent, LinearLayout.LayoutParams.WrapContent);

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AddJob_Tablet);

            gl_Jobs = FindViewById<GridLayout>(Resource.Id.gl_Jobs);
            sv_Jobs = FindViewById<ScrollView>(Resource.Id.scrllV_Jobs);
            lv_Employees = FindViewById<ListView>(Resource.Id.lv_Employees);

            gl_Jobs.ColumnCount = 3;
            gl_Jobs.RowCount = (int)Math.Floor((double)(jobs.Count % 3)) == 0 ? (jobs.Count / 3) : (jobs.Count / 3) + 1;

            int jobIndex = 0;
            foreach (Job J in jobs)
            {
                LinearLayout JobV = new LinearLayout(this);
                JobV.LayoutParameters = lparam;
                JobV.SetHorizontalGravity(GravityFlags.Right);
                JobV.SetBackgroundColor(new Android.Graphics.Color(100, 250, 50));
                JobV.Tag = "ll_" + J.jobID + J.jobName;
                TextView JobVTitle = new TextView(this);
                JobVTitle.LayoutParameters = lparam;
                JobVTitle.Text = J.jobID + ": " + J.jobName;
                JobVTitle.SetTextColor(new Android.Graphics.Color(255, 0, 0));
                JobV.AddView(JobVTitle);
                int children = JobV.ChildCount;
                //JobV.FindViewById<TextView>(Resource.Id.txt_Merge_JobViewTitle).Text = J.jobID + ": " + J.jobName;
                gl_Jobs.AddView(JobV, 
                                new GridLayout.LayoutParams(
                                    GridLayout.InvokeSpec(
                                        (int)Math.Floor(
                                            (double)(jobIndex / 3))), 
                                    GridLayout.InvokeSpec(
                                        (int)Math.Floor(
                                            (double)(jobIndex % 3)))));
                JobVTitle.Invalidate();
                jobIndex++;
            }
            int newint = jobIndex;
            gl_Jobs.RequestLayout();
            sv_Jobs.Click += Sv_Jobs_Click;
            gl_Jobs.Click += Sv_Jobs_Click;
            //lv_Employees.Click += Sv_Jobs_Click;
        }

        private void Sv_Jobs_Click(object sender, EventArgs e)
        {
            Log.Info("scroll jobs", "List of Children: ");
            int childrencount = gl_Jobs.ChildCount;
            for (int i = 0; i < childrencount; i++)
            {
                if (gl_Jobs.GetChildAt(i).Tag != null)
                {
                    Log.Info("scroll jobs", gl_Jobs.GetChildAt(i).Tag.ToString());
                }
                Log.Info("scroll jobs", gl_Jobs.GetChildAt(i).GetType().ToString());
            }
        }
    }
}