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
using Square.Picasso;

namespace ImagePlay3_Droid.Transformations
{
    public abstract class TransformImage : Java.Lang.Object, ITransformation
    {
        private Bitmap result;

        public Bitmap Transform(Bitmap source)
        {
            Bitmap result = Bitmap.CreateBitmap(source.Width, source.Height, Bitmap.Config.Argb8888);

            return Operations(source, result);
        }

        public abstract Bitmap Operations(Bitmap source, Bitmap result);

        public string Key
        {
            get
            {
                return this.GetType().Name;
            }
        }
    }
}