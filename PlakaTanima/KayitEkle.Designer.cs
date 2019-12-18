namespace PlakaTanima
{
    partial class KayitEkle
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.tbSahibi = new System.Windows.Forms.TextBox();
            this.cbDurum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 319);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(381, 42);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sahibi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Durum : ";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbPlaka.Location = new System.Drawing.Point(147, 6);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(227, 38);
            this.tbPlaka.TabIndex = 4;
            // 
            // tbSahibi
            // 
            this.tbSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbSahibi.Location = new System.Drawing.Point(147, 59);
            this.tbSahibi.Name = "tbSahibi";
            this.tbSahibi.Size = new System.Drawing.Size(227, 38);
            this.tbSahibi.TabIndex = 5;
            // 
            // cbDurum
            // 
            this.cbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbDurum.FormattingEnabled = true;
            this.cbDurum.Items.AddRange(new object[] {
            "Gecer",
            "Gecemez"});
            this.cbDurum.Location = new System.Drawing.Point(147, 111);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(227, 39);
            this.cbDurum.TabIndex = 6;
            // 
            // KayitEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 373);
            this.Controls.Add(this.cbDurum);
            this.Controls.Add(this.tbSahibi);
            this.Controls.Add(this.tbPlaka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEkle);
            this.Name = "KayitEkle";
            this.Text = "Kayıt Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.TextBox tbSahibi;
        private System.Windows.Forms.ComboBox cbDurum;
    }
}