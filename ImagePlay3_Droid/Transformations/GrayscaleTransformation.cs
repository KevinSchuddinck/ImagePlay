using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ImagePlay3_Droid.Transformations
{
    class GrayscaleTransformation : TransformImage
    {

        public override Bitmap Operations(Bitmap source, Bitmap result)
        {
            Canvas canvas = new Canvas(result);
            ColorMatrix saturation = new ColorMatrix();
            saturation.SetSaturation(0f);
            Paint paint = new Paint();
            paint.SetColorFilter(new ColorMatrixColorFilter(saturation));
            canvas.DrawBitmap(source, 0, 0, paint);

            source.Recycle();

            return result;
        }
    }
}