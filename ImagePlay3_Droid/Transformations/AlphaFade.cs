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
using Android.Graphics.Drawables;

namespace ImagePlay3_Droid.Transformations
{
    class AlphaFade : TransformImage
    {
        private static Paint mMaskingPaint = new Paint();
        private Context mContext;

        public AlphaFade(Context context)
        {
            mMaskingPaint.SetXfermode(new PorterDuffXfermode(PorterDuff.Mode.SrcIn));
            mContext = context;
        }

        public override Bitmap Operations(Bitmap source, Bitmap result)
        {
            Canvas canvas = new Canvas(result);

            Drawable mask = mContext.Resources.GetDrawable(Resource.Drawable.gradient_bg);
            mask.SetBounds(0, 0, source.Width, source.Height);
            mask.Draw(canvas);
            canvas.DrawBitmap(source, 0, 0, mMaskingPaint);

            source.Recycle();

            return result;
        }
    }
}