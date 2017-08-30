namespace Silmarillion
{
    partial class ImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.characc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.obrazek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.obrazek.Image = ((System.Drawing.Image)(resources.GetObject("obrazek.Image")));
            this.obrazek.Location = new System.Drawing.Point(44, 12);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(201, 219);
            this.obrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obrazek.TabIndex = 0;
            this.obrazek.TabStop = false;
            // 
            // characc
            // 
            this.characc.BackColor = System.Drawing.SystemColors.InfoText;
            this.characc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.characc.ForeColor = System.Drawing.Color.Yellow;
            this.characc.Location = new System.Drawing.Point(44, 237);
            this.characc.Multiline = true;
            this.characc.Name = "characc";
            this.characc.ReadOnly = true;
            this.characc.Size = new System.Drawing.Size(201, 20);
            this.characc.TabIndex = 1;
            this.characc.TabStop = false;
            this.characc.Text = "POSTAĆ";
            this.characc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(291, 263);
            this.Controls.Add(this.characc);
            this.Controls.Add(this.obrazek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(307, 297);
            this.MinimumSize = new System.Drawing.Size(307, 297);
            this.Name = "ImageForm";
            this.Text = "Silmaripedia - podgląd postaci";
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek;
        public System.Windows.Forms.TextBox characc;
    }
}