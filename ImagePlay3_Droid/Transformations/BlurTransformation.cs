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
using Android.Renderscripts;

namespace ImagePlay3_Droid.Transformations
{
    class BlurTransformation : TransformImage
    {
        private static int MAX_RADIUS = 25;
        private static int MIN_RADIUS = 1;

        private Context mContext;

        private int mRadius;

        public BlurTransformation(Context context)
            : this(context, MAX_RADIUS)
        { }

        public BlurTransformation(Context context, int radius)
        {
            mContext = context;
            mRadius = radius < MIN_RADIUS ? MIN_RADIUS : radius > MAX_RADIUS ? MAX_RADIUS : radius; //fancy
        }

        public override Bitmap Operations(Bitmap source, Bitmap result)
        {
            Bitmap originalBitmap = source;
            Bitmap blurredBitmap = null;
            blurredBitmap = Bitmap.CreateBitmap(originalBitmap);

            var rs = RenderScript.Create(mContext);

            var input = Allocation.CreateFromBitmap(rs, originalBitmap,
                Allocation.MipmapControl.MipmapFull, AllocationUsage.Script);
            var output = Allocation.CreateTyped(rs, input.Type);

            var script = ScriptIntrinsicBlur.Create(rs, Element.U8_4(rs));
            script.SetInput(input);
            script.SetRadius(mRadius);

            script.ForEach(output);
            output.CopyTo(blurredBitmap);

            source.Recycle();

            return blurredBitmap;
        }
    }
}