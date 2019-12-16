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

namespace Hangman
{
    [Activity(Label = "WinActivity")]
    public class WinActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Win);

            //Views etc.
            var ExitButton = FindViewById<Button>(Resource.Id.btnCloseWin);

            ExitButton.Click += delegate
            {
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            };
        }
    }
}