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
using Android.Provider;
using Android.Content.PM;
using ImagePlay3_Droid.Custom;
using Android.Graphics;
using Android.Preferences;
using Android.Animation;
using Android.Views.Animations;
using ImageViews.Photo;
using Java.IO;
using static ImagePlay3_Droid.Data.Data;

namespace ImagePlay3_Droid.Activities
{
    [Activity(Label = "CameraActivity", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class CameraActivity : Activity
    {
        private Button btnCamera;
        private Button btnEnlargeImage;
        private CustomImageView picture;

        private Bitmap bitmap;
        private PhotoViewAttacher attacher;

        private bool canRecycleBitmap = true;

        //static dictionary
        private string strGuid;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_Camera);

            btnCamera = FindViewById<Button>(Resource.Id.btnCamera);
            btnEnlargeImage = FindViewById<Button>(Resource.Id.btnEnlargeImage);
            picture = FindViewById<CustomImageView>(Resource.Id.picture);

            
            
            if (savedInstanceState != null)
            {
                //With SavedInstance
                /*
                bitmap = (Bitmap)savedInstanceState.GetParcelable("picture");
                if (bitmap != null)
                {
                    picture.SetImageBitmap(bitmap);
                    attacher = new PhotoViewAttacher(picture);
                }
                */

                //Static dictionary
                /*
                strGuid = savedInstanceState.GetString("pictureGUID");
                if (!string.IsNullOrEmpty(strGuid))
                {
                    bitmap = (Bitmap)myDictionary[strGuid];
                    if (bitmap != null)
                    {
                        picture.SetImageBitmap(bitmap);
                        attacher = new PhotoViewAttacher(picture);
                    }
                }
                */
            }
            
            //With internal storage
            //LoadImageFromInternalStorage("/data/data/ImagePlay3_Droid.ImagePlay3_Droid/app_pictures");
            

            if (CanDeviceTakePictures())
            {
                btnCamera.Click += btnCamera_StartCamera;
            }

            btnEnlargeImage.Click += btnEnlargeImage_Click;
        }

        private void LoadImageFromInternalStorage(string path)
        {
            try
            {
                string combinedPath = path + "/picture.png";
                System.IO.FileStream stream = new System.IO.FileStream(combinedPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                
                bitmap = BitmapFactory.DecodeStream(stream);
                picture.SetImageBitmap(bitmap);
                stream.Close();
            }
            catch(Exception e )
            {
                System.Diagnostics.Debug.Write("Deze lijn: " + e.Message);
            }
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            if (canRecycleBitmap && bitmap != null)
                bitmap.Recycle();

        }

        private string SaveToInternalStorage(Bitmap bitmap)
        {
            ContextWrapper cw = new ContextWrapper(ApplicationContext);
            File directory = cw.GetDir("pictures", FileCreationMode.Private);
            File myPath = new File(directory, "picture.png");

            try
            {
                using (var os = new System.IO.FileStream(myPath.AbsolutePath, System.IO.FileMode.Create))
                {
                    bitmap.Compress(Bitmap.CompressFormat.Png, 100, os);
                    os.Close();
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.Write("Deze lijn: " + e.Message);
            }

            return directory.AbsolutePath;
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            //With savedInstance
            /*
            base.OnSaveInstanceState(outState);
            canRecycleBitmap = false;
            outState.PutParcelable("picture", bitmap);
            */

            //static dictionary
            base.OnSaveInstanceState(outState);
            canRecycleBitmap = false;
            if (!string.IsNullOrEmpty(strGuid))
            {
                outState.PutString("pictureGUID", strGuid);
            }
        }

        private bool CanDeviceTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);

            return availableActivities != null && availableActivities.Count > 0;
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (data != null)
            {
                bitmap = (Bitmap)data.Extras.Get("data");
                picture.SetImageBitmap(bitmap);

                strGuid = Guid.NewGuid().ToString();
                //myDictionary.Add(strGuid, bitmap);

                if (attacher == null)
                {
                    attacher = new PhotoViewAttacher(picture);
                }
                else
                {
                    attacher.Update();
                }
                //string temp = SaveToInternalStorage(bitmap);
            }


        }

        private void btnEnlargeImage_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(CameraActivity));
            StartActivity(intent);
            /*  if (bitmap != null)
              {
                  Intent intent = new Intent(this, typeof(EnlargeImageActivity));
                  intent.PutExtra("enlarged_image", bitmap);
                  StartActivity(intent);
              }            */
        }

        void btnCamera_StartCamera(object sender, EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            StartActivityForResult(intent, 0);
        }

    }
}