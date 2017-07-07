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

namespace ImagePlay3_Droid.Data
{
    public static class Data
    {
        public static Dictionary<string, object> myDictionary = new Dictionary<string, object>();

        private static string[] shaders = {"Standard", "Circle crop", "Grayscale",
            "Inverted colors", "Blurred", "Alpha fade", "Inverse circle crop"};

        /*
        private static string[] imageUrls = {
            "https://ichef.bbci.co.uk/images/ic/480x270/p049tgdb.jpg",
            "https://static.pexels.com/photos/2740/nature-animal-fur-dangerous.jpg",
            "http://mercuryanimal.com/wp-content/uploads/2016/09/cute-3.jpg",
            "https://static.pexels.com/photos/45164/mare-animal-nature-ride-45164.jpeg",
            "http://www.life.org.uk/dump/media/animal-adaptation-animal-adaptation-800-360.jpg",
            "http://r.ddmcdn.com/w_830/s_f/o_1/cx_98/cy_0/cw_640/ch_360/APL/uploads/2015/07/cecil-AP463227356214-1000x400.jpg",
        };*/

        private static IList<string> imageUrls = new List<string>{
            "https://ichef.bbci.co.uk/images/ic/480x270/p049tgdb.jpg",
            "https://static.pexels.com/photos/2740/nature-animal-fur-dangerous.jpg",
            "http://mercuryanimal.com/wp-content/uploads/2016/09/cute-3.jpg",
            "https://static.pexels.com/photos/45164/mare-animal-nature-ride-45164.jpeg",
            "http://www.life.org.uk/dump/media/animal-adaptation-animal-adaptation-800-360.jpg",
            "http://r.ddmcdn.com/w_830/s_f/o_1/cx_98/cy_0/cw_640/ch_360/APL/uploads/2015/07/cecil-AP463227356214-1000x400.jpg",
        };

        public static void AddImage(string imageUrl)
        {
            imageUrls.Add(imageUrl);
        }

        public static string[] Shaders
        {
            get
            {
                return shaders;
            }
        }

        public static IList<string> ImageUrls
        {
            get
            {
                return imageUrls;
            }
        }
    }
}