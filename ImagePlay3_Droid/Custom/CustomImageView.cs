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
using Android.Util;
using Square.Picasso;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views.Animations;

namespace ImagePlay3_Droid.Custom
{
    public class CustomImageView : ImageView
    {
        public CustomImageView (Context context) : base(context)
        { }

        public CustomImageView(Context context, IAttributeSet attrs) : base(context, attrs)
        { }

        public CustomImageView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        { }

        public CustomImageView(Context context, IAttributeSet attrs, int defStyle, int defStyleRes) : base(context, attrs, defStyle, defStyleRes)
        { }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            SetMeasuredDimension(MeasuredWidth, MeasuredHeight);
        }
    }
}