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

using Square.Picasso;
using Android.Graphics;
using ImagePlay3_Droid.Adapters;
using Android.Support.V4.Widget;
using ImagePlay3_Droid.Models;
using static ImagePlay3_Droid.Data.Data;

namespace ImagePlay3_Droid.Activities
{
    [Activity(Label = "MyListActivity")]
    public class MyListActivity : MyImageListActivity
    {
        private ListView mListView;
        
        SwipeRefreshLayout refresher;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_MyListView);
            mListView = FindViewById<ListView>(Resource.Id.listView);
            refresher = FindViewById<SwipeRefreshLayout>(Resource.Id.listRefresher);
            Button btnAddImage = FindViewById<Button>(Resource.Id.btnAddImageList);


            ImageFilterAdapter = new ImageFilterAdapter(this);
            mListView.Adapter = ImageFilterAdapter;

            btnAddImage.Click += btnAddImage_AddImageToList;
            refresher.Refresh += refresher_RefreshList;
        }

        private void btnAddImage_AddImageToList(object sender, EventArgs e)
        {
            PickPictureFromLibrary();
        }

        private void refresher_RefreshList(object sender, EventArgs e)
        {
            var copy = new List<ImageFilter>(ImageFilterAdapter.GetAllItems());
            ImageFilterAdapter.refreshItems(copy);
            refresher.Refreshing = false;
        }
                
        /*
        private void PickPictureFromLibrary()
        {
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            StartActivityForResult(Intent.CreateChooser(intent, "Select picture"), 0);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            if (resultCode == Result.Ok)
            {
                try
                {
                    Android.Net.Uri pictureUri = data.Data;
                    AddImage(pictureUri.ToString());

                    imageFilterAdapter.resetImageList();                    
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.Write("Deze lijn: " + e.Message);
                }
            }
        }
        */
        
    }
}