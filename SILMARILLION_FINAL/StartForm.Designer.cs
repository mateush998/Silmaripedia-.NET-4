namespace SILMARILLION_FINAL
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.yes_butt = new System.Windows.Forms.Button();
            this.no_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes_butt
            // 
            this.yes_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yes_butt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yes_butt.Location = new System.Drawing.Point(61, 138);
            this.yes_butt.Name = "yes_butt";
            this.yes_butt.Size = new System.Drawing.Size(130, 52);
            this.yes_butt.TabIndex = 0;
            this.yes_butt.Text = "TAK";
            this.yes_butt.UseVisualStyleBackColor = true;
            this.yes_butt.Click += new System.EventHandler(this.yes_butt_Click);
            // 
            // no_butt
            // 
            this.no_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.no_butt.Location = new System.Drawing.Point(258, 138);
            this.no_butt.Name = "no_butt";
            this.no_butt.Size = new System.Drawing.Size(130, 52);
            this.no_butt.TabIndex = 1;
            this.no_butt.Text = "NIE";
            this.no_butt.UseVisualStyleBackColor = true;
            this.no_butt.Click += new System.EventHandler(this.no_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "Witaj! Miło Cię widzieć ;) Widzę, że używasz \r\npo raz pierwszy tego programu. Czy" +
    " chcesz \r\nzobaczyć plik pomocy? To okno nie będzie \r\notwierać się przy drugim ur" +
    "uchomieniu \r\nprogramu.";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no_butt);
            this.Controls.Add(this.yes_butt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yes_butt;
        private System.Windows.Forms.Button no_butt;
        private System.Windows.Forms.Label label1;
    }
}