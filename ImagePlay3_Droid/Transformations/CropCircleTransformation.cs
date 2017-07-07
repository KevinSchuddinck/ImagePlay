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
using Android.Graphics.Drawables;

namespace ImagePlay3_Droid.Transformations
{
    class CropCircleTransformation : TransformImage
    {
        private Paint mMaskingPaint;
        private Context mContext;

        public CropCircleTransformation(Context context)
        {
            mMaskingPaint = new Paint();
            mMaskingPaint.SetXfermode(new PorterDuffXfermode(PorterDuff.Mode.SrcIn));
            mContext = context;
        }

        public override Bitmap Operations(Bitmap source, Bitmap result)
        {
            Canvas canvas = new Canvas(result);

            Drawable mask = mContext.Resources.GetDrawable(Resource.Drawable.White_Cricle);
            mask.SetBounds(0, 0, source.Width, source.Height);
            mask.Draw(canvas);

            canvas.DrawBitmap(source, 0, 0, mMaskingPaint);

            source.Recycle();
            return result;
        }
    }
}