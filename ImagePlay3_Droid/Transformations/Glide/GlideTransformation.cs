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
using Com.Bumptech.Glide.Load.Engine.Bitmap_recycle;
using Com.Bumptech.Glide.Load.Resource.Bitmap;

namespace ImagePlay3_Droid.Transformations.Glide
{
    public abstract class GlideTransformation : BitmapTransformation
    {
        public GlideTransformation(Context context):base(context)
        { }

        protected override Bitmap Transform(IBitmapPool bitmapPool, Bitmap source, int outWidth, int outHeight)
        {
            int width = source.Width;
            int height = source.Height;

            int size = Math.Min(width, height);

            Bitmap result = Bitmap.CreateBitmap(source, width, height, size, size);
            

            return Operations(bitmapPool, source, result);
        }

        public abstract Bitmap Operations(IBitmapPool bitmapPool, Bitmap source, Bitmap result);

        public override string Id
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }
}