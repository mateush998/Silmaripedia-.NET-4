namespace Silmarillion
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lista = new System.Windows.Forms.ListBox();
            this.opis = new System.Windows.Forms.RichTextBox();
            this.postac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageShowYes = new System.Windows.Forms.RadioButton();
            this.imageShowNo = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.szukaj1 = new System.Windows.Forms.Button();
            this.resetuj1 = new System.Windows.Forms.Button();
            this.zapisz1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(963, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.ControlText;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(11, 52);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(236, 455);
            this.lista.Sorted = true;
            this.lista.TabIndex = 1;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // opis
            // 
            this.opis.BackColor = System.Drawing.Color.Black;
            this.opis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opis.ForeColor = System.Drawing.SystemColors.Info;
            this.opis.Location = new System.Drawing.Point(254, 52);
            this.opis.Name = "opis";
            this.opis.ReadOnly = true;
            this.opis.Size = new System.Drawing.Size(712, 459);
            this.opis.TabIndex = 2;
            this.opis.Text = "Witaj w programie Silmaripedia, słowniku postaci z powieści J.R.R. Tolkiena - Sil" +
    "marillion.\n\nMiłej lektury :)";
            this.opis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opis_MouseClick);
            // 
            // postac
            // 
            this.postac.BackColor = System.Drawing.Color.Black;
            this.postac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postac.ForeColor = System.Drawing.SystemColors.Info;
            this.postac.Location = new System.Drawing.Point(254, 29);
            this.postac.Name = "postac";
            this.postac.Size = new System.Drawing.Size(440, 13);
            this.postac.TabIndex = 3;
            this.postac.Text = "Wpisz jakąś postać...";
            this.postac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.postac_MouseClick);
            this.postac.KeyUp += new System.Windows.Forms.KeyEventHandler(this.postac_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(9, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Blokuj grafiki?";
            // 
            // imageShowYes
            // 
            this.imageShowYes.AutoSize = true;
            this.imageShowYes.BackColor = System.Drawing.Color.Transparent;
            this.imageShowYes.Checked = true;
            this.imageShowYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imageShowYes.ForeColor = System.Drawing.Color.White;
            this.imageShowYes.Location = new System.Drawing.Point(172, 512);
            this.imageShowYes.Name = "imageShowYes";
            this.imageShowYes.Size = new System.Drawing.Size(48, 20);
            this.imageShowYes.TabIndex = 9;
            this.imageShowYes.TabStop = true;
            this.imageShowYes.Text = "NIE";
            this.imageShowYes.UseVisualStyleBackColor = false;
            this.imageShowYes.CheckedChanged += new System.EventHandler(this.imageShowYes_CheckedChanged);
            // 
            // imageShowNo
            // 
            this.imageShowNo.AutoSize = true;
            this.imageShowNo.BackColor = System.Drawing.Color.Transparent;
            this.imageShowNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageShowNo.ForeColor = System.Drawing.Color.Silver;
            this.imageShowNo.Location = new System.Drawing.Point(238, 512);
            this.imageShowNo.Name = "imageShowNo";
            this.imageShowNo.Size = new System.Drawing.Size(52, 20);
            this.imageShowNo.TabIndex = 10;
            this.imageShowNo.Text = "TAK";
            this.imageShowNo.UseVisualStyleBackColor = false;
            this.imageShowNo.CheckedChanged += new System.EventHandler(this.imageShowNo_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(993, 500);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // szukaj1
            // 
            this.szukaj1.BackColor = System.Drawing.Color.Transparent;
            this.szukaj1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("szukaj1.BackgroundImage")));
            this.szukaj1.Font = new System.Drawing.Font("Ringbearer", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukaj1.ForeColor = System.Drawing.Color.Yellow;
            this.szukaj1.Location = new System.Drawing.Point(700, 12);
            this.szukaj1.Name = "szukaj1";
            this.szukaj1.Size = new System.Drawing.Size(93, 34);
            this.szukaj1.TabIndex = 12;
            this.szukaj1.Text = "Szukaj";
            this.szukaj1.UseVisualStyleBackColor = false;
            this.szukaj1.Click += new System.EventHandler(this.szukaj1_Click_1);
            // 
            // resetuj1
            // 
            this.resetuj1.BackColor = System.Drawing.Color.Transparent;
            this.resetuj1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetuj1.BackgroundImage")));
            this.resetuj1.Font = new System.Drawing.Font("Ringbearer", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetuj1.ForeColor = System.Drawing.Color.Yellow;
            this.resetuj1.Location = new System.Drawing.Point(819, 12);
            this.resetuj1.Name = "resetuj1";
            this.resetuj1.Size = new System.Drawing.Size(86, 34);
            this.resetuj1.TabIndex = 13;
            this.resetuj1.Text = "Reset";
            this.resetuj1.UseVisualStyleBackColor = false;
            this.resetuj1.Click += new System.EventHandler(this.resetuj1_Click);
            // 
            // zapisz1
            // 
            this.zapisz1.Font = new System.Drawing.Font("Ringbearer", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapisz1.ForeColor = System.Drawing.Color.Yellow;
            this.zapisz1.Image = ((System.Drawing.Image)(resources.GetObject("zapisz1.Image")));
            this.zapisz1.Location = new System.Drawing.Point(927, 10);
            this.zapisz1.Name = "zapisz1";
            this.zapisz1.Size = new System.Drawing.Size(86, 36);
            this.zapisz1.TabIndex = 14;
            this.zapisz1.Text = "Zapisz";
            this.zapisz1.UseVisualStyleBackColor = true;
            this.zapisz1.Click += new System.EventHandler(this.zapisz1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 531);
            this.Controls.Add(this.zapisz1);
            this.Controls.Add(this.resetuj1);
            this.Controls.Add(this.szukaj1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imageShowNo);
            this.Controls.Add(this.imageShowYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postac);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1041, 569);
            this.MinimumSize = new System.Drawing.Size(1041, 569);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silmaripedia - słownik postaci";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.RichTextBox opis;
        private System.Windows.Forms.TextBox postac;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton imageShowYes;
        private System.Windows.Forms.RadioButton imageShowNo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button szukaj1;
        private System.Windows.Forms.Button resetuj1;
        private System.Windows.Forms.Button zapisz1;
    }
}

