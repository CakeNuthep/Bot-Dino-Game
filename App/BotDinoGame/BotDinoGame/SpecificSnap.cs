using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotDinoGame
{
    class SpecificSnap
    {
        public static Image Snip(Rectangle rcSelect)
        {
            var rc = Screen.PrimaryScreen.Bounds;
            using (Bitmap bmp = new Bitmap(rc.Width, rc.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
            {
                using (Graphics gr = Graphics.FromImage(bmp))
                    gr.CopyFromScreen(0, 0, 0, 0, bmp.Size);
                SpecificSnap snipper = new SpecificSnap(bmp);
                return snipper.capture(rcSelect);
            }
        }

        Image BackgroundImage;
        public Image Image { get; set; }
        public SpecificSnap(Image screenShot)
        {
            BackgroundImage = screenShot;
        }

        public Image capture(Rectangle rcSelect)
        {
            Image = new Bitmap(rcSelect.Width, rcSelect.Height);
            using (Graphics gr = Graphics.FromImage(Image))
            {
                gr.DrawImage(this.BackgroundImage, new Rectangle(0, 0, Image.Width, Image.Height),
                    rcSelect, GraphicsUnit.Pixel);
                return Image;
            }
        }
    }
}
