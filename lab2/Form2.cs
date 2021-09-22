using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    struct RGB
    {
        public double r;
        public double g;
        public double b;
        public RGB(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
    struct HSV
    {
        public double h;
        public double s;
        public double v;
        public HSV(double h, double s, double v)
        {
            this.h = h;
            this.s = s;
            this.v = v;
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../PicForTask3.jpg");
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    RGB original_rgb = new RGB (c.R, c.G, c.B);
                    HSV original_hsv = RGB_HSV(original_rgb, x, y);
                    RGB modifided_rgb = HSV_RGB(original_hsv);
                    //if (x == 92 && y == 182)
                    //{
                    //    original_rgb.r *= 1;
                    //    original_rgb.g *= 1;
                    //    original_rgb.b *= 1;
                    //    original_hsv.h *= 1;
                    //    original_hsv.s *= 1;
                    //    original_hsv.v *= 1;
                    //    modifided_rgb.r *= 1;
                    //    modifided_rgb.g *= 1;
                    //    modifided_rgb.b *= 1;
                    //}
                    bmp.SetPixel(x, y, Color.FromArgb(255, (int)modifided_rgb.r , (int)modifided_rgb.g, (int)modifided_rgb.b));
                }
            pictureBox1.Image = (Bitmap)bmp;
        }
        //преобразование RGB->HSV
        HSV RGB_HSV(RGB rgb, int x, int y)
        {
            HSV hsv = new HSV(0, 0, 0);
            rgb.r /= 255;
            rgb.g /= 255;
            rgb.b /= 255;
            int max = Math.Max((int)rgb.r, Math.Max((int)rgb.g, (int)rgb.b));
            int min = Math.Min((int)rgb.r, Math.Min((int)rgb.g, (int)rgb.b));
            bool f = false;
            if (max == min) hsv.h = 0;
            else 
            {
                if(max == rgb.r)
                {
                    hsv.h = 60 * ((rgb.g - rgb.b) / (max - min));
                    if (rgb.g < rgb.b)
                        hsv.h += 360;
                }
                else
                {
                    if (max == rgb.g)
                    {
                        hsv.h = 60 * ((rgb.b - rgb.r) / (max - min)) + 120;
                        //if (x == 92 && y == 182) 
                            //f = true;
                    }
                    else
                    {
                        if (max == rgb.b)
                            hsv.h = 60 * ((rgb.r - rgb.g) / (max - min)) + 240;
                    }
                }
            }
            if (max == 0) hsv.s = 0;
            else hsv.s = 1 - (min / max);
            hsv.v = max;
            hsv.s *= 100;
            hsv.v *= 100;
            return hsv;
        }
        //преобразование HSV->RGB
        RGB HSV_RGB(HSV hsv)
        {
            RGB rgb = new RGB(0,0,0);
            double vmin = ((100 - hsv.s) * hsv.v) / 100;
            double a = (hsv.v - vmin) * (hsv.h % 60) / 60;
            double vinc = vmin + a;
            double vdec = vmin - a;
            int hi = (int)Math.Floor((hsv.h / 60)) % 6;
            switch(hi)
            {
                case 0:
                    rgb.r = hsv.v;
                    rgb.g = vinc;
                    rgb.b = vmin;
                    break;
                case 1:
                    rgb.r = vdec;
                    rgb.g = hsv.v;
                    rgb.b = vmin;
                    break;
                case 2:
                    rgb.r = vmin;
                    rgb.g = hsv.v;
                    rgb.b = vinc;
                    break;
                case 3:
                    rgb.r = vmin;
                    rgb.g = vdec;
                    rgb.b = hsv.v;
                    break;
                case 4:
                    rgb.r = vinc;
                    rgb.g = vmin;
                    rgb.b = hsv.v;
                    break;
                case 5:
                    rgb.r = hsv.v;
                    rgb.g = vmin;
                    rgb.b = vdec;
                    break;
                default:
                    break;
            }
            rgb.r *= 2.55;
            rgb.g *= 2.55;
            rgb.b *= 2.55;
            return rgb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../PicForTask3.jpg");
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            for (int y = 100; y < bmp.Height; y++)
                for (int x = 100; x < bmp.Width; x++)
                {
                    //Color c = bmp.GetPixel(x, y);
                    //RGB original_rgb = new RGB(c.R, c.G, c.B);
                    //HSV original_hsv = RGB_HSV(original_rgb);
                    //HSV modifided_hsv = взять из ползунков
                    //RGB modifided_rgb = HSV_RGB(modifided_hsv);
                    //bmp.SetPixel(x, y, Color.FromArgb(255, modifided_rgb.r, modifided_rgb.g, modifided_rgb.b));
                }
            pictureBox1.Image = (Bitmap)bmp;
        }
    }
}