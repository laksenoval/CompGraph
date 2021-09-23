using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        } 
        //Рисует гистограмму
        public Bitmap createHistograms(Bitmap image)
        {
            int width = 768, height = 600;
            Bitmap histogram = new Bitmap(width, height);
            
            int[] R = new int[256];
            int[] G = new int[256];
            int[] B = new int[256];
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color color = image.GetPixel(i, j);
                    R[color.R]++;
                    G[color.G]++;
                    B[color.B]++;
                }
            }

            // Масштабируем гистограммы
            int max = 0;
            for (int i = 0; i < 256; ++i)
            {
                max = R[i] > max ? R[i] : max;
                max = G[i] > max ? G[i] : max;
                max = B[i] > max ? B[i] : max;
            }
            
            double index = (double) max / height;
            for (int i = 0; i < width - 3; ++i)
            {
                for (int j = height - 1; j > height - R[i / 3] / index; --j)
                {
                    histogram.SetPixel(i, j, Color.Red);
                }

                ++i;
                for (int j = height - 1; j > height - G[i / 3] / index; --j)
                {
                    histogram.SetPixel(i, j, Color.Green);
                }

                ++i;
                for (int j = height - 1; j > height - B[i / 3] / index; --j)
                {
                    histogram.SetPixel(i, j, Color.Blue);
                }
            }
            
            return histogram;    
        }
        //Открываем картинку с компьютера
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch 
                {
                    MessageBox.Show("Can't open this file", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Перевод в NTSC RGB
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap temp = new Bitmap(pictureBox1.Image);
            Bitmap result = new Bitmap(temp.Width, temp.Height);
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    Color pixel = temp.GetPixel(i, j);
                    var newPixel1 = 0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B;
                    var newPixel =(int)(newPixel1 <= 255 ? newPixel1 : 255);
                    result.SetPixel(i,j, Color.FromArgb(pixel.A,newPixel,newPixel,newPixel));
                }
            }

            pictureBox5.Image = createHistograms(result);
            pictureBox2.Image = result;
            
        }

        //Перевод в sRGB
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap temp = new Bitmap(pictureBox1.Image);
            Bitmap result = new Bitmap(temp.Width, temp.Height);
            for (int i = 0; i < temp.Width; i++)
            {
                for (int j = 0; j < temp.Height; j++)
                {
                    Color pixel = temp.GetPixel(i, j);
                    var newPixel1 = 0.2126 * pixel.R + 0.7152 * pixel.G + 0.0722 * pixel.B;
                    var newPixel =(int)(newPixel1 <= 255 ? newPixel1 : 255);
                    result.SetPixel(i,j, Color.FromArgb(pixel.A,newPixel,newPixel,newPixel));
                }
            }

            pictureBox6.Image = createHistograms(result);
            pictureBox3.Image = result;
        }

        //Поиск разности
        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap temp1 = new Bitmap(pictureBox2.Image);
            Bitmap temp2 = new Bitmap(pictureBox3.Image);
            Bitmap result = new Bitmap(temp1.Width, temp1.Height);
            for (int i = 0; i < temp1.Width; i++)
            {
                for (int j = 0; j < temp1.Height; j++)
                {
                    Color pixel1 = temp1.GetPixel(i, j);
                    Color pixel2 = temp2.GetPixel(i, j);
                    var newPixel1 = Math.Abs(pixel1.R-pixel2.R) + Math.Abs(pixel1.G-pixel2.G) + Math.Abs(pixel1.B-pixel2.B);
                    var newPixel =(int)(newPixel1 <= 255 ? newPixel1 : 255);
                    result.SetPixel(i,j, Color.FromArgb(255,newPixel,newPixel,newPixel));
                    //result.SetPixel(i,j, Color.FromArgb(255,Math.Abs(pixel1.R-pixel2.R),Math.Abs(pixel1.G-pixel2.G),Math.Abs(pixel1.B-pixel2.B)));
                    //result.SetPixel(i,j, Color.FromArgb(255,Math.Abs(pixel1.R-pixel2.R)*10,Math.Abs(pixel1.G-pixel2.G)*10,Math.Abs(pixel1.B-pixel2.B)*10));
                }
            }

            pictureBox4.Image = result;
        }
    }
}