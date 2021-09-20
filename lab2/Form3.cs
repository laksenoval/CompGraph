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
        public Bitmap CalculateBarChart (Bitmap image)
        {
            int width = 768, height = 600;
            Bitmap histogram = new Bitmap(width, height);
            
            int[] R = new int[256];
            int[] G = new int[256];
            int[] B = new int[256];
            // собираем статистику для изображения
            for (int i = 0; i < image.Width; ++i)
            {
                for (int j = 0; j < image.Height; ++j)
                {
                    Color color = image.GetPixel(i, j);
                    R[color.R]++;
                    G[color.G]++;
                    B[color.B]++;
                }
            }

            // находим самый высокий столбец, чтобы корректно масштабировать гистограмму по высоте
            int max = 0;
            for (int i = 0; i < 256; ++i)
            {
                if (R[i] > max)
                    max = R[i];
                if (G[i] > max)
                    max = G[i];
                if (B[i] > max)
                    max = B[i];
            }

            // определяем коэффициент масштабирования по высоте
            double point = (double) max / height;
            // отрисовываем столбец за столбцом нашу гистограмму с учетом масштаба
            for (int i = 0; i < width - 3; ++i)
            {
                for (int j = height - 1; j > height - R[i / 3] / point; --j)
                {
                    histogram.SetPixel(i, j, Color.Red);
                }

                ++i;
                for (int j = height - 1; j > height - G[i / 3] / point; --j)
                {
                    histogram.SetPixel(i, j, Color.Green);
                }

                ++i;
                for (int j = height - 1; j > height - B[i / 3] / point; --j)
                {
                    histogram.SetPixel(i, j, Color.Blue);
                }
            }
            
            return histogram;    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем изображение
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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

            pictureBox5.Image = CalculateBarChart(result);
            pictureBox2.Image = result;
            
        }

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

            pictureBox6.Image = CalculateBarChart(result);
            pictureBox3.Image = result;
        }
    }
}