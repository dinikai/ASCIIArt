using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ASCIIArt
{
    public partial class Form1 : Form
    {
        public CharsetSettings CharsetSettings { get; set; }

        private static char[][] defaultCharsets = new char[][]
        {
            "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\"^`'. ".ToCharArray(),
            "▓▒░ ".ToCharArray()
        };

        public Form1()
        {
            InitializeComponent();

            if (!File.Exists("charsets.txt"))
            {
                CharsetSettings = new(defaultCharsets);
                CharsetSettings.Serialize("charsets.txt");
            }
            else
                CharsetSettings = CharsetSettings.Deserialize("charsets.txt");

            charsetList.Items.Clear();
            for (int i = 0; i < CharsetSettings.Charsets.Length; i++)
                charsetList.Items.Add(new string(CharsetSettings.Charsets[i]));

            fileButton.Click += (sender, e) =>
            {
                OpenFileDialog openFileDialog = new()
                {
                    Filter = "Image files (*.png, *.jpg, *.gif)|*.png;*.jpg;*.gif"
                };

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                fileText.Text = openFileDialog.FileName;
            };

            drawButton.Click += async (sender, e) =>
            {
                if (charsetList.SelectedIndex == -1)
                    return;

                int width = 0, repeat = 0;
                try
                {
                    width = Convert.ToInt32(widthText.Text);
                    repeat = Convert.ToInt32(repeatText.Text);
                }
                catch
                {
                    return;
                }

                ASCIIArtGenerator artGenerator = new(charsetText.Text);
                Task<string> artTask = artGenerator.DrawArtAsync(fileText.Text, width, repeat);

                ArtForm artForm = new();
                artForm.ArtText = "Drawing...";
                artForm.Show();

                string art = await artTask;
                artForm.ArtText = art;
            };

            charsetList.SelectedIndexChanged += (sender, e) =>
            {
                charsetText.Text = (string)charsetList.SelectedItem;
            };
            saveButton.Click += (sender, e) =>
            {
                if (charsetList.SelectedIndex == -1)
                    return;

                charsetList.Items[charsetList.SelectedIndex] = charsetText.Text;

                char[][] charsets = new char[charsetList.Items.Count][];
                for (int i = 0; i < charsets.Length; i++)
                    charsets[i] = ((string)charsetList.Items[i]).ToCharArray();
                CharsetSettings.Charsets = charsets;

                CharsetSettings.Serialize("charsets.txt");
            };

            addButton.Click += (sender, e) =>
            {
                charsetList.Items.Add("");
                charsetList.SelectedIndex = charsetList.Items.Count - 1;
            };
            removeButton.Click += (sender, e) =>
            {
                if (charsetList.SelectedIndex != -1 || charsetList.Items.Count > 1)
                {
                    charsetList.Items.RemoveAt(charsetList.SelectedIndex);

                    char[][] charsets = new char[charsetList.Items.Count][];
                    for (int i = 0; i < charsets.Length; i++)
                        charsets[i] = ((string)charsetList.Items[i]).ToCharArray();
                    CharsetSettings.Charsets = charsets;
                    CharsetSettings.Serialize("charsets.txt");
                }
            };
        }
    }
}