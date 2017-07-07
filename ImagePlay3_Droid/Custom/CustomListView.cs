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
    class CustomListView : ListView
    {
        public CustomListView(Context context):base(context)
        { }

        public CustomListView(Context context, IAttributeSet attrs):base(context, attrs)
        { }

        public CustomListView(Context context, IAttributeSet attrs, int defStyle)
            :base(context, attrs, defStyle)
        { }

        protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
        {
            ImageFilterAdapter adapter = (ImageFilterAdapter)Adapter;
            ItemView.InitItemLayout(1, adapter.getItemCount());

            base.OnLayout(changed, left, top, right, bottom);
        }
    }
}