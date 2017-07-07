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

namespace ImagePlay3_Droid.Utils
{
    public static class ScreenSize
    {
        public static Point ScreenSizeDp(Context context)
        {
            var metrics = context.Resources.DisplayMetrics;

            var dpWidth = PxToDp.ConvertPixelsToDp(metrics.WidthPixels, context);
            var dpHeight = PxToDp.ConvertPixelsToDp(metrics.HeightPixels, context);

            return new Point(dpWidth, dpHeight);
        }

    }
}