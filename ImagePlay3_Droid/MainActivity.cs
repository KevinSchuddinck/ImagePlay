using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

using System;
using ImagePlay3_Droid.Activities;
using Android.Runtime;

using static ImagePlay3_Droid.Data.Data;
using Android.Content.PM;

namespace ImagePlay3_Droid
{
    [Activity(Label = "ImagePlay3_Droid", MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : TabActivity
    {
        private bool pictureAdded = false;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            CreateAllTabs();
        }

        private void CreateAllTabs()
        {
            CreateTab(typeof(MyListActivity), "Listview", "Listview");
            CreateTab(typeof(MyCollectionActivity), "Collectionview", "Collectionview");
            CreateTab(typeof(CameraActivity), "Camera", "Camera");
        }

        private void CreateTab(Type activity, string tag, string label)
        {
            var intent = new Intent(this, activity);
            intent.AddFlags(ActivityFlags.NewTask);

            var spec = TabHost.NewTabSpec(tag);
            spec.SetIndicator(label);
            spec.SetContent(intent);

            TabHost.AddTab(spec);
        }
    }
}

