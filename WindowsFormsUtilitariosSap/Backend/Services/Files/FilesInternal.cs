using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using WindowsFormsUtilitariosSap.Backend.DTOs;
using WindowsFormsUtilitariosSap.Backend.Services.Images;

namespace WindowsFormsUtilitariosSap.Backend.Services.Files
{
    public class FilesInternal
    {
        internal readonly string IMAGES_PATH;

        public FilesInternal()
        {
            try
            {
                IMAGES_PATH = ConfigurationManager.AppSettings["IMAGES_PATH"];
            }
            catch
            {
                IMAGES_PATH = string.Empty;
            }
        }

        public async Task<List<AnalysisDataDto>> GetImageOfProduct(List<AnalysisDataDto> analysisDataDto)
        {
            await Task.Run(() => Parallel.ForEach(analysisDataDto, item => {
                try
                {
                    var req = System.Net.WebRequest.Create(IMAGES_PATH + item.MATNR + ".jpg");
                    using (Stream stream = req.GetResponse().GetResponseStream())
                    {
                        var images = ImageOperation.TransformByteToImage(ReadFully(stream));

                        item.IMAGE_SET = images.Item1;
                        item.IMAGE_SMALL_SIZE = images.Item1;
                        item.IMAGE_REAL_SIZE = images.Item2;
                        item.IMAGE_SET_VALUE = false;
                    }
                }
                catch
                {
                    item.IMAGE_SET = (Image)Properties.Resources._404;
                    item.IMAGE_SMALL_SIZE = (Image)Properties.Resources._404;
                    item.IMAGE_REAL_SIZE = (Image)Properties.Resources._404;
                    item.IMAGE_SET_VALUE = false;
                }
            }));

            return analysisDataDto;
        }

        private byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
