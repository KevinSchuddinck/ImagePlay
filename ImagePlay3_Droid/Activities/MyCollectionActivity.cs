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
using ImagePlay3_Droid.Adapters;
using Android.Support.V4.Widget;
using ImagePlay3_Droid.Models;
using ImagePlay3_Droid.Custom;

namespace ImagePlay3_Droid.Activities
{
    [Activity(Label = "CollectionActivity")]
    public class MyCollectionActivity : MyImageListActivity
    {
        private SwipeRefreshLayout refresher;
        private AutoMeasureGridView gridview;
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_MyCollectionView);

            gridview = FindViewById<AutoMeasureGridView>(Resource.Id.gridview);
            //gridview.Expanded = true;
            refresher = FindViewById<SwipeRefreshLayout>(Resource.Id.gridRefresher);

            Button btnAddImage = FindViewById<Button>(Resource.Id.btnAddImageCollection);

            ImageFilterAdapter = new ImageFilterAdapter(this, true);
            gridview.Adapter = ImageFilterAdapter;

            refresher.Refresh += refresher_RefreshGrid;

            btnAddImage.Click += btnAddImage_AddImageToList;
        }

        private void btnAddImage_AddImageToList(object sender, EventArgs e)
        {
            PickPictureFromLibrary();
        }

        private void refresher_RefreshGrid(object sender, EventArgs e)
        {
            var copy = new List<ImageFilter>(ImageFilterAdapter.GetAllItems());
            ImageFilterAdapter.refreshItems(copy);
            refresher.Refreshing = false;
        }
    }
}