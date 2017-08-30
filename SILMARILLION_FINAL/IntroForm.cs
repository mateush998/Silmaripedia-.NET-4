using System;
using System.Windows.Forms;

namespace Silmarillion
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ladowanie.Increment(1);
            if (ladowanie.Value == 100)
            {
                timer1.Stop();
                (new MainForm()).Show();
                this.Hide();
            }
        }
    }
}
