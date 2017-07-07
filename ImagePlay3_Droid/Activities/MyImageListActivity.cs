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
using static ImagePlay3_Droid.Data.Data;
using ImagePlay3_Droid.Adapters;

namespace ImagePlay3_Droid.Activities
{
    [Activity(Label = "MyImageListActivity")]
    public abstract class MyImageListActivity : Activity
    {

        public ImageFilterAdapter ImageFilterAdapter { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);            
        }

        public void PickPictureFromLibrary()
        {
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            StartActivityForResult(Intent.CreateChooser(intent, "Select picture"), 0);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            if (resultCode == Result.Ok)
            {
                try
                {
                    Android.Net.Uri pictureUri = data.Data;
                    AddImage(pictureUri.ToString());

                    ImageFilterAdapter.resetImageList();
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.Write("Deze lijn: " + e.Message);
                }
            }
        }
    }
}