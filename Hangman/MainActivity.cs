using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace Hangman
{
    [Activity(Label = "Hangman", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Sets initial screen to the main menu
            SetContentView (Resource.Layout.Main);

            //Views and variables
            var ChangeBtn = FindViewById<Button>(Resource.Id.ChangeButton);

            //Play Game click event
            ChangeBtn.Click += delegate
            {
                Intent activity = new Intent(this, typeof(GameplayActivity));
                StartActivity(activity);
            };
        }
    }
}

