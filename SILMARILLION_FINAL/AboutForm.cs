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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jestę artystę");
        }

        private void LABE2_Click(object sender, EventArgs e)
        {

        }

        private void help_button_Click(object sender, EventArgs e)
        {
            string helpFileName = @"DATA_BIN\Silmaripedia - plik pomocy.chm";
            if (System.IO.File.Exists(helpFileName))
            {
                Help.ShowHelp(this, helpFileName);
            }
        }
    }
}
