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

namespace ImagePlay3_Droid.Models
{
    public class ImageFilter
    {
        public long Id
        { get; set; }

        public int ImageId
        { get; set; }

        public string FilterName
        { get; set; }

        public string ImageUrl
        { get; set; }
        
    }
}