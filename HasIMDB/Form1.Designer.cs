namespace HasIMDB
{
    partial class Form1
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
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rbPuanYok = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboPhoto = new System.Windows.Forms.PictureBox();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(6, 308);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(177, 29);
            this.btnFilmEkle.TabIndex = 0;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilmId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gboPuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFilmEkle);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pboPhoto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 364);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Detayları";
            // 
            // txtFilmId
            // 
            this.txtFilmId.Location = new System.Drawing.Point(200, 62);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.ReadOnly = true;
            this.txtFilmId.Size = new System.Drawing.Size(167, 24);
            this.txtFilmId.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Film No:";
            // 
            // gboPuan
            // 
            this.gboPuan.Controls.Add(this.rbPuanYok);
            this.gboPuan.Controls.Add(this.label2);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Location = new System.Drawing.Point(9, 103);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(177, 199);
            this.gboPuan.TabIndex = 3;
            this.gboPuan.TabStop = false;
            // 
            // rbPuanYok
            // 
            this.rbPuanYok.AutoSize = true;
            this.rbPuanYok.Checked = true;
            this.rbPuanYok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuanYok.Location = new System.Drawing.Point(21, 46);
            this.rbPuanYok.Name = "rbPuanYok";
            this.rbPuanYok.Size = new System.Drawing.Size(69, 19);
            this.rbPuanYok.TabIndex = 9;
            this.rbPuanYok.TabStop = true;
            this.rbPuanYok.Text = "Puansız";
            this.rbPuanYok.UseVisualStyleBackColor = true;
            this.rbPuanYok.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puan:";
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan5.Location = new System.Drawing.Point(21, 171);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(77, 19);
            this.rbPuan5.TabIndex = 8;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "5 - Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            this.rbPuan5.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan1.Location = new System.Drawing.Point(21, 71);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(91, 19);
            this.rbPuan1.TabIndex = 4;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "1 - Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            this.rbPuan1.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan2.Location = new System.Drawing.Point(21, 96);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(67, 19);
            this.rbPuan2.TabIndex = 5;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "2 - Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            this.rbPuan2.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan4.Location = new System.Drawing.Point(21, 146);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(53, 19);
            this.rbPuan4.TabIndex = 7;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "4 - İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            this.rbPuan4.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan3.Location = new System.Drawing.Point(21, 121);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(65, 19);
            this.rbPuan3.TabIndex = 6;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "3 - Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            this.rbPuan3.CheckedChanged += new System.EventHandler(this.rbPuanYok_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(203, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resmi Değiştirmek İçin Üzerine Tıklayın";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(6, 62);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(167, 24);
            this.txtFilmAd.TabIndex = 2;
            this.txtFilmAd.TextChanged += new System.EventHandler(this.txtFilmAd_TextChanged);
            this.txtFilmAd.Leave += new System.EventHandler(this.txtFilmAd_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // pboPhoto
            // 
            this.pboPhoto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboPhoto.Location = new System.Drawing.Point(203, 113);
            this.pboPhoto.Name = "pboPhoto";
            this.pboPhoto.Size = new System.Drawing.Size(175, 189);
            this.pboPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboPhoto.TabIndex = 0;
            this.pboPhoto.TabStop = false;
            this.pboPhoto.Click += new System.EventHandler(this.pboPhoto_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.DisplayMember = "id";
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 18;
            this.lstFilmler.Location = new System.Drawing.Point(430, 12);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(262, 364);
            this.lstFilmler.TabIndex = 0;
            this.lstFilmler.ValueMember = "id";
            this.lstFilmler.SelectedIndexChanged += new System.EventHandler(this.lstFilmler_SelectedIndexChanged);
            this.lstFilmler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFilmler_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Resim Dosyaları (*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 391);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "HasIMDB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboPhoto;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPuanYok;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

