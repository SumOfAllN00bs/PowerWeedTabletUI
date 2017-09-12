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

namespace PowerWeedTabletUI
{
    [Activity(Label = "EmployeeEditActivity_Tablet")]
    public class EmployeeEditActivity_Tablet : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Employees_Tablet);
        }
    }
}