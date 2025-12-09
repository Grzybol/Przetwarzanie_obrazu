using System.Diagnostics;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.Util.TypeEnum;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Emgu.CV.Util;
using static System.Net.Mime.MediaTypeNames;
using Emgu.CV.Reg;
using static Emgu.Util.Platform;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Emgu.CV.Flann;
using ImageProcessingLab;
namespace WinFormsApp1BMP
{

    //Install-Package Emgu.CV
    //Install-Package Emgu.CV.Bitmap
    //
    public partial class MainForm : Form
    {

        Utils utils = new Utils();
        Mat _image;
        Bitmap _imageLoaded1;
        Bitmap _imageLoaded2;
        double img1Rratio = 0.4;
        double img1Gratio = 0.4;
        double img1Bratio = 0.4;
        double img2Rratio = 0.6;
        double img2Gratio = 0.6;
        double img2Bratio = 0.6;
        public MainForm()
        {
            InitializeComponent();
            Htxt.Text = H.Value.ToString();
            Stxt.Text = S.Value.ToString();
            Vtxt.Text = V.Value.ToString();
            H2txt.Text = H2.Value.ToString();
            S2txt.Text = S2.Value.ToString();
            V2txt.Text = V2.Value.ToString();

        }

        private void LoadImage1btn_Click(object sender, EventArgs e)
        {
            try
            {
                var loaded = LoadBitmapFileWindow();
                _imageLoaded1 = loaded.Bitmap;

                pictureBox1.Image = _imageLoaded1;
                Image1Label.Text = loaded.Filename;
                PictureWindow pictureWindow = new PictureWindow(_imageLoaded1, "original");
                pictureWindow.Show();

                Recalculate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadImage2btn_Click(object sender, EventArgs e)
        {
            var loaded = LoadBitmapFileWindow();
            _imageLoaded2 = loaded.Bitmap;
            this.Text = loaded.Filename;
            pictureBox2.Image = _imageLoaded2;
            PictureWindow pictureWindow = new PictureWindow(_imageLoaded2, "original");
            pictureWindow.Show();
            Recalculate();
        }


        public void Recalculate()
        {
            //var img = AdjustBrightnessContrast(_imageLoaded1, H.Value, S.Value);
            // var img=ROzciagnijHistogram(_imageLoaded1)
            // pictureBox2.Image = img;

            //var win = new PictureWindow(img, "Contrast");
            if (_imageLoaded2 == null)

            {
                var naszObraz = _imageLoaded1;

                // pobranie wymiarów obrazu
                int wysokosc = naszObraz.Height;
                int szerokosc = naszObraz.Width;
                //
                // utworzenie nowej bitmapy
                Bitmap bmpR = new Bitmap(szerokosc, wysokosc);
                Bitmap bmpG = new Bitmap(szerokosc, wysokosc);
                Bitmap bmpB = new Bitmap(szerokosc, wysokosc);
                //
                // pobranie wartości pixela
                Color colorR, colorG, colorB;
                for (int i = 0; i < szerokosc; i++)
                {
                    for (int j = 0; j < wysokosc; j++)
                    {
                        var loadedPixel = _imageLoaded1.GetPixel(i, j);
                        colorR = Color.FromArgb(loadedPixel.R, 0, 0);
                        colorG = Color.FromArgb(0, loadedPixel.G, 0);
                        colorB = Color.FromArgb(0, 0, loadedPixel.B);

                        bmpR.SetPixel(i, j, colorR);
                        bmpG.SetPixel(i, j, colorG);
                        bmpB.SetPixel(i, j, colorB);
                    }
                }
                pictureBox1.Image = bmpR;
                pictureBox2.Image = bmpG;
                pictureBox3.Image = bmpB;
            }
            else if (_imageLoaded1 != null && _imageLoaded2 != null)
            {


                var naszObraz1 = _imageLoaded1;
                var naszObraz2 = _imageLoaded2;


                // pobranie wymiarów obrazu
                int wysokosc1 = naszObraz1.Height;
                int szerokosc1 = naszObraz1.Width;
                //
                int wysokosc2 = naszObraz2.Height;
                int szerokosc2 = naszObraz2.Width;

                if (wysokosc1 != wysokosc2 || szerokosc1 != szerokosc2)
                {
                    MessageBox.Show("Obrazy musz mieć ta sama rozdzielczosć!");
                    return;
                }

                // utworzenie nowej bitmapy
                Bitmap bmpR = new Bitmap(szerokosc1, wysokosc1);
                Bitmap bmpG = new Bitmap(szerokosc1, wysokosc1);
                Bitmap bmpB = new Bitmap(szerokosc1, wysokosc1);
                //
                // pobranie wartości pixela
                Color colorR, colorG, colorB;
                for (int i = 0; i < szerokosc1; i++)
                {
                    for (int j = 0; j < wysokosc1; j++)
                    {
                        var loadedPixel1 = _imageLoaded1.GetPixel(i, j);
                        var loadedPixel2 = _imageLoaded2.GetPixel(i, j);



                        colorR = Color.FromArgb(System.Convert.ToInt32(loadedPixel1.R * img1Rratio + loadedPixel2.R * img2Rratio), 0, 0);
                        colorG = Color.FromArgb(0, System.Convert.ToInt32(loadedPixel1.G * img1Gratio + loadedPixel2.G * img2Gratio), 0);
                        colorB = Color.FromArgb(0, 0, System.Convert.ToInt32(loadedPixel1.B * img1Bratio + loadedPixel2.B * img2Bratio));

                        bmpR.SetPixel(i, j, colorR);
                        bmpG.SetPixel(i, j, colorG);
                        bmpB.SetPixel(i, j, colorB);
                    }
                }
                pictureBox1.Image = bmpR;
                pictureBox2.Image = bmpG;
                pictureBox3.Image = bmpB;

            }

            // bmp.GetPixel(x, y);
            //
            // ustawienie wartości pixela
            // bmp.SetPixel(x, y, color);
            //
            // stworzenie zmiennej typu color
            // Color c = Color.FromArgb(redValue, greenValue, blueValue);
            //
            // zapisanie Bitmapy do pliku 
            // bmp.Save("example.bmp");

        }
        private void H_Scroll(object sender, EventArgs e)
        {
            Htxt.Text = H.Value.ToString();
        }
        private void S_Scroll(object sender, EventArgs e)
        {
            Stxt.Text = S.Value.ToString();
        }
        private void V_Scroll(object sender, EventArgs e)
        {
            Vtxt.Text = V.Value.ToString();
        }
        private void H2_Scroll(object sender, EventArgs e)
        {
            H2txt.Text = H2.Value.ToString();
        }
        private void S2_Scroll(object sender, EventArgs e)
        {
            S2txt.Text = S2.Value.ToString();
        }
        private void V2_Scroll(object sender, EventArgs e)
        {
            V2txt.Text = V2.Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Recalculate();
        }
        private void Htxt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(Htxt.Text.Trim(), out int val))
            {
                H.Value = val;
            }
        }
        private void Stxt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(Stxt.Text.Trim(), out int val))
            {
                S.Value = val;
            }
        }
        private void Vtxt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(Vtxt.Text.Trim(), out int val))
            {
                V.Value = val;
            }
        }
        private void H2txt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(H2txt.Text.Trim(), out int val))
            {
                H2.Value = val;
            }
        }
        private void S2txt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(S2txt.Text.Trim(), out int val))
            {
                S2.Value = val;
            }
        }
        private void V2txt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(V2txt.Text.Trim(), out int val))
            {
                V2.Value = val;
            }
        }
        private (Bitmap Bitmap, string Filename) LoadBitmapFileWindow()
        {
            Bitmap image = null;
            string filename = string.Empty;
            try
            {
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.PNG;*.JPG;*.JPEG;*.BMP";
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    var file = openFileDialog1.FileName;
                    this.Text = file;
                    image = new Bitmap(file);
                }
            }
            catch (Exception ex) { throw ex; }
            return (image, filename);
        }

        private void HistBtn_Click(object sender, EventArgs e)
        {

            int[] histogramR = new int[256];
            int[] histogramG = new int[256];
            int[] histogramB = new int[256];

            var naszObraz = _imageLoaded1;

            // pobranie wymiarów obrazu
            int wysokosc = naszObraz.Height;
            int szerokosc = naszObraz.Width;
            //
            // utworzenie nowej bitmapy
            Bitmap bmpR = new Bitmap(szerokosc, wysokosc);
            Bitmap bmpG = new Bitmap(szerokosc, wysokosc);
            Bitmap bmpB = new Bitmap(szerokosc, wysokosc);
            //
            // pobranie wartości pixela
            Color colorR, colorG, colorB;
            for (int i = 0; i < szerokosc; i++)
            {
                for (int j = 0; j < wysokosc; j++)
                {
                    var loadedPixel = _imageLoaded1.GetPixel(i, j);

                    int indexR = loadedPixel.R;
                    int indexG = loadedPixel.G;
                    int indexB = loadedPixel.B;



                    histogramR[indexR] += 1;
                    histogramG[indexG] += 1;
                    histogramB[indexB] += 1;




                    colorR = Color.FromArgb(loadedPixel.R, 0, 0);
                    colorG = Color.FromArgb(0, loadedPixel.G, 0);
                    colorB = Color.FromArgb(0, 0, loadedPixel.B);

                    bmpR.SetPixel(i, j, colorR);
                    bmpG.SetPixel(i, j, colorG);
                    bmpB.SetPixel(i, j, colorB);
                }
            }


            // ROZCIĄGANIE HISTOGRAMU
            // ===============================

            // Szukamy minimum i maksimum niezerowego
            int minR = utils.FindMin(histogramR);
            int maxR = utils.FindMax(histogramR);

            int minG = utils.FindMin(histogramG);
            int maxG = utils.FindMax(histogramG);

            int minB = utils.FindMin(histogramB);
            int maxB = utils.FindMax(histogramB);

            // "rozciągnięte" histogramy
            int[] stretchedR = new int[256];
            int[] stretchedG = new int[256];
            int[] stretchedB = new int[256];

            for (int i = 0; i < 256; i++)
            {
                if (histogramR[i] > 0)
                {
                    int newIndex = utils.ScaleValue(i, minR, maxR);
                    stretchedR[newIndex] += histogramR[i];
                }

                if (histogramG[i] > 0)
                {
                    int newIndex = utils.ScaleValue(i, minG, maxG);
                    stretchedG[newIndex] += histogramG[i];
                }

                if (histogramB[i] > 0)
                {
                    int newIndex = utils.ScaleValue(i, minB, maxB);
                    stretchedB[newIndex] += histogramB[i];
                }
            }

            List<Series> series = new List<Series>();



            Series red = new Series
            {
                Name = "Red",
                Color = Color.Red,
                ChartType = SeriesChartType.Line
            };

            Series green = new Series
            {
                Name = "Green",
                Color = Color.Green,
                ChartType = SeriesChartType.Line
            };

            Series blue = new Series
            {
                Name = "Blue",
                Color = Color.Blue,
                ChartType = SeriesChartType.Line
            };

            //stary histogram

            for (int i = 0; i <= 255; i++)
            {
                red.Points.AddXY(i, histogramR[i]);
                green.Points.AddXY(i, histogramG[i]);
                blue.Points.AddXY(i, histogramB[i]);
            }


            //nowy rozciagniety histogram
            /*
            for (int i = 0; i <= 255; i++)
            {
                red.Points.AddXY(i, stretchedR[i]);
                green.Points.AddXY(i, stretchedG[i]);
                blue.Points.AddXY(i, stretchedB[i]);
            }
            */


            series.Add(red);
            series.Add(green);
            series.Add(blue);

            ChartWindow chart = new ChartWindow(series, "Histogran obrazu - rozciagniety");

            chart.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void gauss_button_Click_1(object sender, EventArgs e)
        {
            {
                if (_imageLoaded1 == null)
                    return;

                Bitmap blurred = utils.GaussianBlur(_imageLoaded1);
                _imageLoaded1 = blurred;
                pictureBox3.Image = _imageLoaded1;
            }
        }

        private void hist_button_2_Click(object sender, EventArgs e)
        {


            int[] histogramR = new int[256];
            int[] histogramG = new int[256];
            int[] histogramB = new int[256];

            var naszObraz = _imageLoaded1;

            // pobranie wymiarow obrazu
            int wysokosc = naszObraz.Height;
            int szerokosc = naszObraz.Width;
            //
            // utworzenie nowej bitmapy
            Bitmap bmpR = new Bitmap(szerokosc, wysokosc);
            Bitmap bmpG = new Bitmap(szerokosc, wysokosc);
            Bitmap bmpB = new Bitmap(szerokosc, wysokosc);
            //
            // pobranie wartosci pixela
            Color colorR, colorG, colorB;
            for (int i = 0; i < szerokosc; i++)
            {
                for (int j = 0; j < wysokosc; j++)
                {
                    var loadedPixel = _imageLoaded1.GetPixel(i, j);

                    int indexR = loadedPixel.R;
                    int indexG = loadedPixel.G;
                    int indexB = loadedPixel.B;



                    histogramR[indexR] += 1;
                    histogramG[indexG] += 1;
                    histogramB[indexB] += 1;




                    colorR = Color.FromArgb(loadedPixel.R, 0, 0);
                    colorG = Color.FromArgb(0, loadedPixel.G, 0);
                    colorB = Color.FromArgb(0, 0, loadedPixel.B);

                    bmpR.SetPixel(i, j, colorR);
                    bmpG.SetPixel(i, j, colorG);
                    bmpB.SetPixel(i, j, colorB);
                }
            }


            // ROZCIAGANIE HISTOGRAMU
            // ===============================

            // Szukamy minimum i maksimum niezerowego
            int minR = utils.FindMin(histogramR);
            int maxR = utils.FindMax(histogramR);

            int minG = utils.FindMin(histogramG);
            int maxG = utils.FindMax(histogramG);

            int minB = utils.FindMin(histogramB);
            int maxB = utils.FindMax(histogramB);

            // "rozciagniete" histogramy
            int[] stretchedR = new int[256];
            int[] stretchedG = new int[256];
            int[] stretchedB = new int[256];

            for (int i = 0; i < 256; i++)
            {
                if (histogramR[i] > 0)
                {
                    int newIndex = utils.ScaleValue(i, minR, maxR);
                    stretchedR[newIndex] += histogramR[i];
                }

                if (histogramG[i] > 0)
                {
                    int newIndex = utils.ScaleValue(i, minG, maxG);
                    stretchedG[newIndex] += histogramG[i];
                }

                if (histogramB[i] > 0)
                {
                    int newIndex = utils.ScaleValue(i, minB, maxB);
                    stretchedB[newIndex] += histogramB[i];
                }
            }

            List<Series> series = new List<Series>();



            Series red = new Series
            {
                Name = "Red",
                Color = Color.Red,
                ChartType = SeriesChartType.Line
            };

            Series green = new Series
            {
                Name = "Green",
                Color = Color.Green,
                ChartType = SeriesChartType.Line
            };

            Series blue = new Series
            {
                Name = "Blue",
                Color = Color.Blue,
                ChartType = SeriesChartType.Line
            };

            //stary histogram
            /*
            for (int i = 0; i <= 255; i++)
            {
                red.Points.AddXY(i, histogramR[i]);
                green.Points.AddXY(i, histogramG[i]);
                blue.Points.AddXY(i, histogramB[i]);
            }   
            */

            //nowy rozciagniety histogram
            for (int i = 0; i <= 255; i++)
            {
                red.Points.AddXY(i, stretchedR[i]);
                green.Points.AddXY(i, stretchedG[i]);
                blue.Points.AddXY(i, stretchedB[i]);
            }


            series.Add(red);
            series.Add(green);
            series.Add(blue);

            ChartWindow chart = new ChartWindow(series, "Histogran obrazu - rozciagniety");

            chart.Show();
        }
    }
}
    

