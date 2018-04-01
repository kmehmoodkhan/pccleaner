using PCCleaner.Controls.Common;
using PCCleaner.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner.Common
{
    public static class Helper
    {
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public static List<ListItem> GetExplorerFeatures()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (ExplorerFeatures feature in Enum.GetValues(typeof(ExplorerFeatures)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("ExplorerFeature_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static List<ListItem> GetSystemFeatures()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (SystemFeatures feature in Enum.GetValues(typeof(SystemFeatures)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("SystemFeature_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }

        public static List<ListItem> GetAdvancedFeatures()
        {
            List<ListItem> list = new List<ListItem>();

            foreach (AdvancedFeatures feature in Enum.GetValues(typeof(AdvancedFeatures)))
            {
                ListItem item = new ListItem() { ItemId = Convert.ToInt32(feature), ItemText = Resources.ResourceManager.GetString("AdvancedFeature_" + Convert.ToInt32(feature)) };
                list.Add(item);
            }
            return list;
        }
    }
}
