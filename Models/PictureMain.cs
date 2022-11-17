using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21App.Models
{
    public class PictureMain
    {
        public string PicturePath { get; set; }
    }

    public class PictureMainManager
    {
        public static List<PictureMain> GetPictureMainList()
        {
            var pictures = new List<PictureMain>();

            pictures.Add(new PictureMain { PicturePath = "Assets/a.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/b.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/c.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/d.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/e.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/f.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/g.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/h.jpg" });
            pictures.Add(new PictureMain { PicturePath = "Assets/i.jpg" });

            return pictures;
        }
    }
}
