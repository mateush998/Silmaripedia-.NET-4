namespace Silmarillion
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LABE1 = new System.Windows.Forms.Label();
            this.LABE2 = new System.Windows.Forms.Label();
            this.LABE3 = new System.Windows.Forms.Label();
            this.OK_btn = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LABE1
            // 
            this.LABE1.AutoSize = true;
            this.LABE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LABE1.ForeColor = System.Drawing.Color.White;
            this.LABE1.Location = new System.Drawing.Point(12, 12);
            this.LABE1.Name = "LABE1";
            this.LABE1.Size = new System.Drawing.Size(262, 48);
            this.LABE1.TabIndex = 1;
            this.LABE1.Text = "Silmaripedia - komputerowy słownik \r\npostaci z uniwersum\r\nSilmarillion J.R.R. Tol" +
    "kiena";
            // 
            // LABE2
            // 
            this.LABE2.AutoSize = true;
            this.LABE2.ForeColor = System.Drawing.Color.White;
            this.LABE2.Location = new System.Drawing.Point(12, 147);
            this.LABE2.Name = "LABE2";
            this.LABE2.Size = new System.Drawing.Size(274, 65);
            this.LABE2.TabIndex = 2;
            this.LABE2.Text = "Mateusz Podsiadło 2015, Szczecin\r\nKorekta i refactoring: Andrzej Prusinowski\r\n\r\nW" +
    " razie problemów, zgłaszać je ze zdjęciem i opisem na:\r\ne-mail: matis.poo@wp.pl";
            this.LABE2.Click += new System.EventHandler(this.LABE2_Click);
            // 
            // LABE3
            // 
            this.LABE3.AutoSize = true;
            this.LABE3.ForeColor = System.Drawing.Color.Red;
            this.LABE3.Location = new System.Drawing.Point(12, 103);
            this.LABE3.Name = "LABE3";
            this.LABE3.Size = new System.Drawing.Size(284, 13);
            this.LABE3.TabIndex = 3;
            this.LABE3.Text = "Silmaripedia, v.1.0.6.7 - wersja posiada wpisane 47 postaci";
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(443, 189);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 4;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // help_button
            // 
            this.help_button.Location = new System.Drawing.Point(332, 189);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(75, 23);
            this.help_button.TabIndex = 5;
            this.help_button.Text = "Pomoc";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(530, 226);
            this.ControlBox = false;
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.LABE3);
            this.Controls.Add(this.LABE2);
            this.Controls.Add(this.LABE1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(546, 260);
            this.MinimumSize = new System.Drawing.Size(546, 260);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silmaripedia - InfoBOX";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LABE1;
        private System.Windows.Forms.Label LABE2;
        private System.Windows.Forms.Label LABE3;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Button help_button;
    }
}