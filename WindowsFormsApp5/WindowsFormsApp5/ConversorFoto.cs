using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financias
{
    class ConversorFoto
    {
        public Image CambiarTamañoImagen(Image image, int v1)
        {
            Bitmap bmp = new Bitmap(v1, v1);
            using (Graphics gph = Graphics.FromImage((Image)bmp))
            {
                gph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gph.DrawImage(image, 0, 0, v1, v1);
            }
            return (Image)bmp;
        }
    }
}
