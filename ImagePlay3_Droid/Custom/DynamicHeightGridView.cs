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

namespace ImagePlay3_Droid.Custom
{
    class DynamicHeightGridView : GridView
    {
        private bool expanded = false;

        public bool Expanded
        {
            get
            {
                return expanded;
            }
            set
            {
                expanded = value;
            }
        }

        public DynamicHeightGridView(Context context)
            :base(context)
        {    }

        public DynamicHeightGridView(Context context, IAttributeSet attrs)
            :base(context, attrs)
        {    }

        public DynamicHeightGridView(Context context, IAttributeSet attrs,
                int defStyle)
            :base(context, attrs, defStyle)
        {    }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            int heightSpec;
            if(LayoutParameters.Height == LayoutParams.WrapContent)
            {
                //int expandSpec = MeasureSpec.MakeMeasureSpec(MeasuredSizeMask, MeasureSpecMode.AtMost);
                //base.OnMeasure(widthMeasureSpec, expandSpec);

                //ViewGroup.LayoutParams vgParams = LayoutParameters;
                //vgParams.Height = MeasuredHeight;
                //SetMeasuredDimension(MeasuredWidth, MeasuredHeight);
                heightSpec = MeasureSpec.MakeMeasureSpec( int.MaxValue, MeasureSpecMode.AtMost);
            }
            else
            {
                heightSpec = heightMeasureSpec;
            }

            base.OnMeasure(widthMeasureSpec, heightSpec);
        }
    }
}