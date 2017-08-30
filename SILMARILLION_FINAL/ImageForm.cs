using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silmarillion
{
    public partial class ImageForm : Form
    {

        public ImageForm()
        {
            InitializeComponent();
        }

        public ImageForm LoadImage(string file, string description)
        {
            obrazek.Image = Bitmap.FromFile(@"DATA_BIN/ch_i/s_" + file + ".jpg");
            characc.Text = description.ToUpper();

            return this;
        }
    }
}
