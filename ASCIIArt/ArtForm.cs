using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCIIArt
{
    public partial class ArtForm : Form
    {
        public string ArtText
        {
            get => artText.Text;
            set => artText.Text = value;
        }

        public ArtForm()
        {
            InitializeComponent();

            copyButton.Click += (sender, e) => Clipboard.SetText(artText.Text);
        }
    }
}
