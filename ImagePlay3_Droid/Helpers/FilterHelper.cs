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
using ImagePlay3_Droid.Custom;
using ImagePlay3_Droid.Models;
using Square.Picasso;
using ImagePlay3_Droid.Transformations;
using Android.Views.Animations;
using Com.Bumptech.Glide;
using ImagePlay3_Droid.Transformations.Glide;

namespace ImagePlay3_Droid.Helpers
{
    public class FilterHelper
    {
        private static FilterHelper instance;

        private FilterHelper() { }

        const int IMAGE_SIZE = 175;

        public static FilterHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FilterHelper();
                }

                return instance;
                    
            }
        }

        public void ApplyFilter(CustomImageView imageView, ImageFilter imageFilter, Activity activity, ProgressBar progressbar)
        {
            ITransformation transform = null;
            switch (imageFilter.FilterName)
            {
                case "Circle crop":
                    transform = new CropCircleTransformation(activity);
                    break;
                case "Grayscale":
                    transform = new GrayscaleTransformation();
                    break;
                case "Inverted colors":
                    transform = new InvertColorsTransformation();
                    break;
                case "Blurred":
                    transform = new BlurTransformation(activity);
                    break;
                case "Alpha fade":
                    transform = new AlphaFade(activity);
                    break;
                case "Inverse circle crop":
                    transform = new InvertCropCircleTransformation(activity);
                    break;
                default:
                    break;
            }

            Action onSucces = delegate {
                Animation fadeOut = new AlphaAnimation(0, 1);
                fadeOut.Interpolator = new AccelerateInterpolator();
                fadeOut.Duration = 1000;
                imageView.StartAnimation(fadeOut);
                progressbar.Visibility = ViewStates.Gone;
            };

            Action onError = delegate {

            };

            
            if (transform != null)
            {
                Picasso.With(activity.ApplicationContext)
                        .Load(imageFilter.ImageUrl)
                        .Resize(IMAGE_SIZE, IMAGE_SIZE)
                        .Transform(transform)                        
                        .NoFade()
                        .Into(imageView, onSucces, onError); 
            }
            else
            {
                Picasso.With(activity.ApplicationContext)
                        .Load(imageFilter.ImageUrl)
                        .Resize(IMAGE_SIZE, IMAGE_SIZE)
                        .NoFade()                        
                        .Into(imageView, onSucces, onError); 
            }
            
        }
    }
}