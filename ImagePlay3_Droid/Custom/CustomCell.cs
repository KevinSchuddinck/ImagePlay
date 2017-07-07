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
using ImagePlay3_Droid.Utils;

namespace ImagePlay3_Droid.Custom
{
    class CustomCell : LinearLayout
    {
        const int MIN_HEIGHT = 100;
        const int MAX_HEIGHT = 400;

        public CustomCell(Context context) : base(context)
        { }

        public CustomCell(Context context, IAttributeSet attrs) : base(context, attrs)
        { }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            
            var height = MeasuredHeight < MIN_HEIGHT ? MIN_HEIGHT : MeasuredHeight > MAX_HEIGHT ? MAX_HEIGHT : MeasuredHeight;

            SetMeasuredDimension(MeasuredWidth, height);
        }
        
    }
}