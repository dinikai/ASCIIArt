using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArt
{
    public class CharsetSettings
    {
        public char[][] Charsets { get; set; }

        public CharsetSettings(char[][] charsets)
        {
            Charsets = charsets;
        }

        public void Serialize(string file)
        {
            using StreamWriter writer = new(file);
            foreach (char[] charset in Charsets)
                writer.WriteLine(charset);
        }

        public static CharsetSettings Deserialize(string file)
        {
            using StreamReader reader = new(file);
            List<char[]> charsets = new();
            while (!reader.EndOfStream)
                charsets.Add(reader.ReadLine()!.ToCharArray());

            return new CharsetSettings(charsets.ToArray());
        }
    }
}
