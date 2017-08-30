namespace Silmarillion
{
    partial class IntroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.lejbel = new System.Windows.Forms.Label();
            this.ladowanie = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lejbel
            // 
            this.lejbel.AutoSize = true;
            this.lejbel.BackColor = System.Drawing.Color.Black;
            this.lejbel.ForeColor = System.Drawing.Color.Yellow;
            this.lejbel.Location = new System.Drawing.Point(12, 235);
            this.lejbel.Name = "lejbel";
            this.lejbel.Size = new System.Drawing.Size(297, 52);
            this.lejbel.TabIndex = 1;
            this.lejbel.Text = "Silmaripedia - v.1.0.6.8\r\nMateusz Podsiadło feat. AP\r\n2015 Szczecin\r\nProgram jest" +
    " prezentem dla Adrianny, pozdro dla kumatych <3";
            // 
            // ladowanie
            // 
            this.ladowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ladowanie.ForeColor = System.Drawing.Color.Red;
            this.ladowanie.Location = new System.Drawing.Point(15, 12);
            this.ladowanie.Name = "ladowanie";
            this.ladowanie.Size = new System.Drawing.Size(531, 23);
            this.ladowanie.Step = 20;
            this.ladowanie.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ladowanie.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 307);
            this.Controls.Add(this.ladowanie);
            this.Controls.Add(this.lejbel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(558, 307);
            this.MinimumSize = new System.Drawing.Size(558, 307);
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTRO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lejbel;
        private System.Windows.Forms.ProgressBar ladowanie;
        private System.Windows.Forms.Timer timer1;
    }
}