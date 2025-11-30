using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingLab
{
    internal class Utils
    {
        public int FindMin(int[] hist)
        {
            for (int i = 0; i < 256; i++)
            {
                if (hist[i] > 0)
                    return i;
            }
            return 0;
        }

        // Szukanie ostatniego niezerowego (maksimum)
        public int FindMax(int[] hist)
        {
            for (int i = 255; i >= 0; i--)
            {
                if (hist[i] > 0)
                    return i;
            }
            return 255;
        }

        // Skalowanie wartości z zakresu [min, max] na [0, 255]
        public int ScaleValue(int value, int min, int max)
        {
            if (min == max)
                return value; // brak zmian jeśli zakres pusty

            int newValue = (value - min) * 255 / (max - min);

            if (newValue < 0) newValue = 0;
            if (newValue > 255) newValue = 255;

            return newValue;
        }

        //Rozmycie gaussa
        public Bitmap GaussianBlur(Bitmap source)
        {
            int width = source.Width;
            int height = source.Height;

            Bitmap result = new Bitmap(width, height);

            // Na start kopiujemy cały obraz, żeby mieć brzegi bez kombinowania
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    result.SetPixel(x, y, source.GetPixel(x, y));
                }
            }

            // Właściwe rozmycie tylko dla pikseli, które mają pełne sąsiedztwo 3x3
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    // 3x3 pikseli wokół (x,y)
                    Color c00 = source.GetPixel(x - 1, y - 1);
                    Color c01 = source.GetPixel(x, y - 1);
                    Color c02 = source.GetPixel(x + 1, y - 1);

                    Color c10 = source.GetPixel(x - 1, y);
                    Color c11 = source.GetPixel(x, y);     // środek
                    Color c12 = source.GetPixel(x + 1, y);

                    Color c20 = source.GetPixel(x - 1, y + 1);
                    Color c21 = source.GetPixel(x, y + 1);
                    Color c22 = source.GetPixel(x + 1, y + 1);

                    // Gauss 3x3: (1 2 1 / 2 4 2 / 1 2 1) / 16

                    int r =
                        (c00.R + 2 * c01.R + c02.R +
                         2 * c10.R + 4 * c11.R + 2 * c12.R +
                         c20.R + 2 * c21.R + c22.R) / 16;

                    int g =
                        (c00.G + 2 * c01.G + c02.G +
                         2 * c10.G + 4 * c11.G + 2 * c12.G +
                         c20.G + 2 * c21.G + c22.G) / 16;

                    int b =
                        (c00.B + 2 * c01.B + c02.B +
                         2 * c10.B + 4 * c11.B + 2 * c12.B +
                         c20.B + 2 * c21.B + c22.B) / 16;

                    // Tu matematycznie i tak będzie w zakresie 0–255, więc bez clampów
                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return result;
        }

    }
}
