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
using ImagePlay3_Droid.Adapters;

namespace ImagePlay3_Droid.Custom
{
    class AutoMeasureGridView : GridView
    {
        public AutoMeasureGridView(Context context):base(context)
        {        }

        public AutoMeasureGridView(Context context, IAttributeSet attrs):base(context, attrs)
        {        }

        public AutoMeasureGridView(Context context, IAttributeSet attrs, int defStyle)
            :base(context, attrs, defStyle)
        {        }

        protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
        {
            if(changed)
            {
                ImageFilterAdapter adapter = (ImageFilterAdapter)Adapter;

                ItemView.InitItemLayout(NumColumns, adapter.getItemCount());

                if(NumColumns > 1)
                {
                    int columnWidth = MeasuredWidth / NumColumns;
                    adapter.MeasureItems(columnWidth);
                }
            }

            base.OnLayout(changed, left, top, right, bottom);
        }
    }
}