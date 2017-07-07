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
    class ItemView : LinearLayout
    {
        const int MIN_HEIGHT = 100;
        const int MAX_HEIGHT = 400;

        private static int[] mMaxRowHeight;

        private static int mNumColums;

        private int mPosition;
        public int Position
        {
            get { return mPosition; }
            set { mPosition = value; }
        }

        public ItemView(Context context) : base(context)
        {        }
        
        public ItemView(Context context, IAttributeSet attrs) : base(context, attrs)
        {        }
        
        public static void InitItemLayout(int numColums, int itemCount)
        {
            mNumColums = numColums;
            mMaxRowHeight = new int[itemCount];
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);

            int height = MeasuredHeight;

            if (mNumColums <= 1 || mMaxRowHeight == null)
            {
                return;
            }
            else if (mNumColums > 1)
            {

                int rowIndex = mPosition / mNumColums;
                if (MeasuredHeight > mMaxRowHeight[rowIndex])
                {
                    mMaxRowHeight[rowIndex] = MeasuredHeight;
                }

                var currentHeight = mMaxRowHeight[rowIndex];

                height = currentHeight < MIN_HEIGHT ? MIN_HEIGHT : currentHeight > MAX_HEIGHT ? MAX_HEIGHT : currentHeight;
            }

            SetMeasuredDimension(MeasuredWidth, height);
        }

    }
}