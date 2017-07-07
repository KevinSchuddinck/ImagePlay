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
    class InvertColorsTransformation : TransformImage
    {
        public override Bitmap Operations(Bitmap source, Bitmap result)
        {
            Canvas canvas = new Canvas(result);
            Paint paint = new Paint();

            float[] NEGATIVE = new float[] {
                    -1.0f,     0,     0,    0,      255, // red
                        0, -1.0f,     0,    0,      255, // green
                        0,     0, -1.0f,    0,      255, // blue
                        0,     0,     0,    1.0f,     0  // alpha  
                };

            paint.SetColorFilter(new ColorMatrixColorFilter(NEGATIVE));
            canvas.DrawBitmap(source, 0, 0, paint);

            source.Recycle();

            return result;
        }
    }
}