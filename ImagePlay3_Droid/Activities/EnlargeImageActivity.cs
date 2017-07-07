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
using Android.Graphics;

namespace ImagePlay3_Droid.Activities
{
    [Activity(Label = "EnlargeImageActivity")]
    public class EnlargeImageActivity : Activity
    {
        private Bitmap bitmap;
        private ImageView picture;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_EnglareImage);

            picture = FindViewById<ImageView>(Resource.Id.bigImage);

            bitmap = (Bitmap)Intent.GetParcelableExtra("enlarged_image");

            picture.SetImageBitmap(bitmap);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            bitmap.Recycle();
        }

        public override void OnBackPressed()
        {
            Finish();
        }
    }
}