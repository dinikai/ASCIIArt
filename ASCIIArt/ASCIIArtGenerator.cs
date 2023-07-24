using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArt
{
    public class ASCIIArtGenerator
    {
        public char[] Charset { get; set; }

        public ASCIIArtGenerator(char[] charset) =>
            Charset = charset;

        public ASCIIArtGenerator(string charset) =>
            Charset = charset.ToCharArray();

        public async Task<string> DrawArtAsync(string path, int width, int repeat)
        {
            Bitmap bitmap = await Task.Run(() => new Bitmap(path));

            int span = bitmap.Width / width * 2;
            if (span < 1)
                span = 1;
            string art = "";

            for (int x = 0; x < bitmap.Height; x += span)
            {
                for (int y = 0; y < bitmap.Width; y += span)
                {
                    List<int> averageArray = new(), averageAlphaArray = new();
                    Color color = bitmap.GetPixel(y, x);

                    for (int i = 0; i < span; i++)
                        for (int j = 0; j < span; j++)
                        {
                            averageArray.AddRange(new int[] { color.R, color.G, color.B });
                            averageAlphaArray.Add(color.A);
                        }

                    int averageAlpha = averageAlphaArray.Aggregate((a, b) => a + b) / averageAlphaArray.Count;
                    int average = averageArray.Aggregate((a, b) => a + b) / averageArray.Count * (averageAlpha / 255);

                    float shade = 225 / Charset.Length;
                    char character = (char)0;

                    for (int i = 1; i <= Charset.Length; i++)
                    {
                        if (average < shade * i || i == Charset.Length)
                        {
                            character = Charset[i - 1];
                            break;
                        }
                    }

                    for (int i = 0; i < repeat; i++)
                        art += character;
                }
                art += "\n";
            }

            return art;
        }
    }
}
