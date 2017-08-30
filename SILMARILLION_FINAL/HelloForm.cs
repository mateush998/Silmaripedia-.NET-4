using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Silmarillion
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string helpFileName = @"DATA_BIN\Silmaripedia - plik pomocy.chm";
            if (System.IO.File.Exists(helpFileName))
            {
                Help.ShowHelp(this, helpFileName);
            }

            File.WriteAllText(@"DATA_BIN\LOG.txt", "1");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"DATA_BIN\LOG.txt", "1");

            this.Close();
        }
    }
}
