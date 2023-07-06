using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUtilitariosSap.Backend.Services.Images
{
    public class ImageOperation
    {
        public static Tuple<Image,Image> TransformByteToImage(byte[] imageByte)
        {
            try
            {
                Bitmap imageBitmap = new Bitmap(new MemoryStream(imageByte));
                return new Tuple<Image,Image>(ResizeImage((Image)imageBitmap), (Image)imageBitmap);
            }
            catch
            {
                return new Tuple<Image, Image>((Image)Properties.Resources.fail, (Image)Properties.Resources.fail);
            }
        }

        private static Image ResizeImage(Image image)
        {
            try
            {
                return (Image)(new Bitmap(image, new Size(100, 100)));
            }
            catch
            {
                return (Image)Properties.Resources.fail;
            }
        }
    }
}
