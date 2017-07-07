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
using ImagePlay3_Droid.Custom;
using Android.Graphics;
using ImagePlay3_Droid.Models;

namespace ImagePlay3_Droid.Helpers
{
    class ViewHelper : Java.Lang.Object
    {
        private View mView;
        private Activity mActivity;
        private ProgressBar mProgressbar;

        public TextView Icon { get; set; }
        public TextView ImageFilterName { get; set; }
        public CustomImageView Image { get; set; }

        public ViewHelper(Activity activity, View view)
        {
            mView = view;
            mActivity = activity;

            Icon = mView.FindViewById<TextView>(Resource.Id.icon);
            ImageFilterName = mView.FindViewById<TextView>(Resource.Id.filterName);
            Image = mView.FindViewById<CustomImageView>(Resource.Id.image);

            Icon.Typeface = Typeface.CreateFromAsset(mActivity.Assets, "kinepolis.ttf");

            mProgressbar = mView.FindViewById<ProgressBar>(Resource.Id.progressbar);
        }

        public void PrepareCell(ImageFilter imageFilter)
        {
            ImageFilterName.Text = imageFilter.FilterName;

            FilterHelper.Instance.ApplyFilter(Image, imageFilter, mActivity, mProgressbar);
        }

        public void ResizeImage()
        {
            Image.RequestLayout();
            Image.LayoutParameters.Height = 175;
        }
    }
}