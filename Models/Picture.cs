using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21App.Models
{
    public class Picture
    {
        public string PicturePath { get; set; }
    }

    public class PictureManager
    {
        public static List<Picture> GetPictures()
        {
            var pictures = new List<Picture>();
            pictures.Add(new Picture { PicturePath = "Assets/a.jpg" });
            pictures.Add(new Picture { PicturePath = "Assets/b.jpg" });
            pictures.Add(new Picture { PicturePath = "Assets/c.jpg" });

            return pictures;
        }
    }
}
