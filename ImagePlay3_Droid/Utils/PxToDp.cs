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

namespace ImagePlay3_Droid.Utils
{
    public static class PxToDp
    {
        public static int ConvertPixelsToDp(float pixelValue, Context context)
        {
            return (int)((pixelValue) / context.Resources.DisplayMetrics.Density);
        }
    }
}