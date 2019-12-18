namespace PlakaTanima
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer kodu

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoOrjinal = new System.Windows.Forms.PictureBox();
            this.fotoPlaka = new System.Windows.Forms.PictureBox();
            this.btnTanima = new System.Windows.Forms.Button();
            this.dosyaSec = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblSahibi = new System.Windows.Forms.Label();
            this.lblEklenme = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnPlakaEkle = new System.Windows.Forms.Button();
            this.btnPlakaSil = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSonKullanim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoOrjinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPlaka)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(894, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Plaka Resmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Resim Yolu:";
            // 
            // fotoOrjinal
            // 
            this.fotoOrjinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoOrjinal.Location = new System.Drawing.Point(13, 41);
            this.fotoOrjinal.Margin = new System.Windows.Forms.Padding(4);
            this.fotoOrjinal.Name = "fotoOrjinal";
            this.fotoOrjinal.Size = new System.Drawing.Size(870, 616);
            this.fotoOrjinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoOrjinal.TabIndex = 12;
            this.fotoOrjinal.TabStop = false;
            // 
            // fotoPlaka
            // 
            this.fotoPlaka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPlaka.Location = new System.Drawing.Point(894, 514);
            this.fotoPlaka.Margin = new System.Windows.Forms.Padding(4);
            this.fotoPlaka.Name = "fotoPlaka";
            this.fotoPlaka.Size = new System.Drawing.Size(391, 143);
            this.fotoPlaka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPlaka.TabIndex = 11;
            this.fotoPlaka.TabStop = false;
            // 
            // btnTanima
            // 
            this.btnTanima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTanima.Location = new System.Drawing.Point(894, 41);
            this.btnTanima.Margin = new System.Windows.Forms.Padding(4);
            this.btnTanima.Name = "btnTanima";
            this.btnTanima.Size = new System.Drawing.Size(388, 46);
            this.btnTanima.TabIndex = 10;
            this.btnTanima.Text = "Plakayı Bul";
            this.btnTanima.UseVisualStyleBackColor = true;
            this.btnTanima.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // dosyaSec
            // 
            this.dosyaSec.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png|All files (*.*)|*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(890, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Plaka :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(890, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sahibi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(890, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Eklenme Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(890, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sonuç :";
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblPlaka.Location = new System.Drawing.Point(961, 106);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(0, 24);
            this.lblPlaka.TabIndex = 20;
            // 
            // lblSahibi
            // 
            this.lblSahibi.AutoSize = true;
            this.lblSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSahibi.Location = new System.Drawing.Point(968, 149);
            this.lblSahibi.Name = "lblSahibi";
            this.lblSahibi.Size = new System.Drawing.Size(0, 24);
            this.lblSahibi.TabIndex = 21;
            // 
            // lblEklenme
            // 
            this.lblEklenme.AutoSize = true;
            this.lblEklenme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblEklenme.Location = new System.Drawing.Point(1038, 197);
            this.lblEklenme.Name = "lblEklenme";
            this.lblEklenme.Size = new System.Drawing.Size(0, 24);
            this.lblEklenme.TabIndex = 22;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSonuc.Location = new System.Drawing.Point(968, 283);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 24);
            this.lblSonuc.TabIndex = 23;
            // 
            // btnPlakaEkle
            // 
            this.btnPlakaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlakaEkle.Location = new System.Drawing.Point(894, 413);
            this.btnPlakaEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlakaEkle.Name = "btnPlakaEkle";
            this.btnPlakaEkle.Size = new System.Drawing.Size(190, 46);
            this.btnPlakaEkle.TabIndex = 24;
            this.btnPlakaEkle.Text = "Plaka Ekle";
            this.btnPlakaEkle.UseVisualStyleBackColor = true;
            this.btnPlakaEkle.Click += new System.EventHandler(this.btnPlakaEkle_Click);
            // 
            // btnPlakaSil
            // 
            this.btnPlakaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlakaSil.Location = new System.Drawing.Point(1092, 413);
            this.btnPlakaSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlakaSil.Name = "btnPlakaSil";
            this.btnPlakaSil.Size = new System.Drawing.Size(190, 46);
            this.btnPlakaSil.TabIndex = 25;
            this.btnPlakaSil.Text = "Plaka Sil";
            this.btnPlakaSil.UseVisualStyleBackColor = true;
            this.btnPlakaSil.Click += new System.EventHandler(this.btnPlakaSil_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.Location = new System.Drawing.Point(890, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Son Kullanım Tarihi:";
            // 
            // lblSonKullanim
            // 
            this.lblSonKullanim.AutoSize = true;
            this.lblSonKullanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblSonKullanim.Location = new System.Drawing.Point(1074, 238);
            this.lblSonKullanim.Name = "lblSonKullanim";
            this.lblSonKullanim.Size = new System.Drawing.Size(0, 24);
            this.lblSonKullanim.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 666);
            this.Controls.Add(this.lblSonKullanim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPlakaSil);
            this.Controls.Add(this.btnPlakaEkle);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblEklenme);
            this.Controls.Add(this.lblSahibi);
            this.Controls.Add(this.lblPlaka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fotoOrjinal);
            this.Controls.Add(this.fotoPlaka);
            this.Controls.Add(this.btnTanima);
            this.Name = "Form1";
            this.Text = "Plaka Tanıma Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.fotoOrjinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPlaka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fotoOrjinal;
        private System.Windows.Forms.PictureBox fotoPlaka;
        private System.Windows.Forms.Button btnTanima;
        private System.Windows.Forms.OpenFileDialog dosyaSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblSahibi;
        private System.Windows.Forms.Label lblEklenme;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnPlakaEkle;
        private System.Windows.Forms.Button btnPlakaSil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSonKullanim;
    }
}

