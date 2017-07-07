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
using ImagePlay3_Droid.Models;
using Java.Lang;
using ImagePlay3_Droid.Custom;
using ImagePlay3_Droid.Helpers;
using static ImagePlay3_Droid.Data.Data;
using Android.Graphics;
using static Android.Views.View;

namespace ImagePlay3_Droid.Adapters
{
    public class ImageFilterAdapter : BaseAdapter
    {
        List<ImageFilter> mImageList;
        Activity mActivity;

        const int NUMBER_IMAGES = 50;

        private bool resizeImage;

        public ImageFilterAdapter(Activity activity, bool resize = false)
        {
            mActivity = activity;
            resizeImage = resize;
            fillImages();
            
        }

        public override int Count
        {
            get
            {
                return mImageList.Count;
            }
        }

        public void fillImages()
        {
            mImageList = new List<ImageFilter>();
            
            Random rand = new Random();

            for(int i = 0; i < NUMBER_IMAGES; ++i)
            {
                ImageFilter img = new ImageFilter();
                img.Id = Convert.ToInt64(i);
                //img.ImageId = Resource.Drawable.Seal_of_Approval;
                img.ImageUrl = ImageUrls[rand.Next(0, ImageUrls.Count)];
                img.FilterName = Shaders[i%Shaders.Length];
                mImageList.Add(img);
            }

        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return mImageList[position].Id;
        }

        public List<ImageFilter> GetAllItems()
        {
            return mImageList;
        }

        public int getItemCount()
        {
            return mImageList.Count;
        }

        public void refreshItems(List<ImageFilter> list)
        {
            mImageList.Clear();
            mImageList.AddRange(list);
            this.NotifyDataSetChanged();
        }

        public void resetImageList()
        {
            fillImages();
            this.NotifyDataSetChanged();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View itemView = convertView;
            ViewHelper viewHelper = null;

            if(itemView == null)
            {
                itemView = convertView ?? mActivity.LayoutInflater.Inflate(
                    Resource.Layout.Item, parent, false);

                viewHelper = new ViewHelper(mActivity, itemView);

                itemView.Tag = viewHelper;
            }
            else
            {
                viewHelper = (ViewHelper)itemView.Tag;
            }

            viewHelper.PrepareCell(mImageList[position]);
    
            
            if(resizeImage)
            {
                viewHelper.ResizeImage();
            }         

            return itemView;
        }

        public void MeasureItems(int columnWidth)
        {
            LayoutInflater inflater = mActivity.LayoutInflater;
            ItemView itemView = (ItemView)inflater.Inflate(Resource.Layout.Item,null);

            int widthMeasureSpec = MeasureSpec.MakeMeasureSpec(columnWidth, MeasureSpecMode.Exactly);
            int heightMeasureSpec = MeasureSpec.MakeMeasureSpec(0, MeasureSpecMode.Unspecified);

            for(int i = 0; i < mImageList.Count; ++i)
            {
                itemView.Position = i;

                itemView.RequestLayout();
                itemView.Measure(widthMeasureSpec, heightMeasureSpec);
            }
        }
    }
}