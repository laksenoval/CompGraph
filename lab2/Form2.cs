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
        //RGB original_rgb;
        //HSV original_hsv;

        bool Equal(double x, double y, double eps = 0.0001)
        => Math.Abs(x - y) < eps;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RGB rgb1 = new RGB(137.0, 15.0, 235.0);
            HSV hsv = RGB_HSV(rgb1);
            RGB rgb2 = HSV_RGB(hsv);
            if (Equal(rgb1.r, rgb2.r) && Equal(rgb1.g, rgb2.g) && Equal(rgb1.b, rgb2.b))
                textBox1.Text = "OK";
            else
                textBox1.Text = "WRONG!!!";
            pictureBox1.Image = Image.FromFile("../../PicForTask3.jpg");
        }

        HSV RGB_HSV(RGB rgb)
        {
            HSV hsv = new HSV(0.0, 0.0, 0.0);
            double max = Math.Max(rgb.r, Math.Max(rgb.g, rgb.b));
            double min = Math.Min(rgb.r, Math.Min(rgb.g, rgb.b));
            if (Equal(max, min)) hsv.h = 0.0;
            else 
            {
                if(Equal(max, rgb.r))
                {
                    hsv.h = 60.0 * ((rgb.g - rgb.b) / (max - min));
                    if (rgb.g < rgb.b)
                        hsv.h += 360;
                }
                else
                {
                    if (Equal(max, rgb.g))
                        hsv.h = 60.0 * ((rgb.b - rgb.r) / (max - min)) + 120;
                    else
                    {
                        if (Equal(max, rgb.b))
                            hsv.h = 60.0 * ((rgb.r - rgb.g) / (max - min)) + 240;
                    }
                }
            }
            if (Equal(max, 0.0)) hsv.s = 0.0;
            else hsv.s = 1 - (min / max);
            hsv.v = max;
            return hsv;
        }
        
        RGB HSV_RGB(HSV hsv)
        {
            RGB rgb = new RGB(0.0,0.0,0.0);
            double hi = Math.Floor(hsv.h / 60.0) % 6;
            double f = hsv.h / 60.0 - Math.Floor(hsv.h / 60.0);
            double p = hsv.v*(1 - hsv.s);
            double q = hsv.v*(1 - f*hsv.s);
            double t = hsv.v*(1-(1 - f)*hsv.s);
            switch(hi)
            {
                case 0:
                    rgb.r = hsv.v;
                    rgb.g = t;
                    rgb.b = p;
                    break;
                case 1:
                    rgb.r = q;
                    rgb.g = hsv.v;
                    rgb.b = p;
                    break;
                case 2:
                    rgb.r = p;
                    rgb.g = hsv.v;
                    rgb.b = t;
                    break;
                case 3:
                    rgb.r = p;
                    rgb.g = q;
                    rgb.b = hsv.v;
                    break;
                case 4:
                    rgb.r = t;
                    rgb.g = p;
                    rgb.b = hsv.v;
                    break;
                case 5:
                    rgb.r = hsv.v;
                    rgb.g = p;
                    rgb.b = q;
                    break;
                default:
                    break;
            }
            return rgb;
        }

        void change_by_tracks()
        {
            double H = trackBar1.Value;
            double S = trackBar2.Value / 100.0;
            double V = trackBar3.Value / 100.0;
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    RGB original_rgb = new RGB(c.R / 255.0, c.G / 255.0, c.B / 255.0);
                    HSV original_hsv = RGB_HSV(original_rgb);
                    HSV new_hsv = original_hsv;
                    new_hsv.h += H;
                    if (new_hsv.h > 360)
                        new_hsv.h -= 360;
                    if (new_hsv.h < 0)
                        new_hsv.h += 360;
                    new_hsv.s += S;
                    new_hsv.s = Math.Min(1, new_hsv.s);
                    new_hsv.s = Math.Max(0, new_hsv.s);
                    new_hsv.v += V;
                    new_hsv.v = Math.Min(1, new_hsv.v);
                    new_hsv.v = Math.Max(0, new_hsv.v);
                    RGB modifided_rgb = HSV_RGB(new_hsv);
                    int h1 = (int)(modifided_rgb.r * 255);
                    int h2 = (int)(modifided_rgb.g * 255);
                    int h3 = (int)(modifided_rgb.b * 255);
                    bmp.SetPixel(x, y, Color.FromArgb(255, h1, h2, h3));
                }
            pictureBox1.Image = (Bitmap)bmp;
        }

        void save_to_file()
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Save image as...";
                save.OverwritePrompt = true;
                save.CheckPathExists = true;
                save.Filter = "Image Files(*.jpg)|*.jpg|All files (*.*)|*.*";
                save.ShowHelp = true;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Unable to save image", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change_by_tracks();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            save_to_file();
        }
    }
}