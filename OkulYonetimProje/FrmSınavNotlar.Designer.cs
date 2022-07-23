namespace OkulYonetimProje
{
    partial class FrmSınavNotlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSınav1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.TxtSınav2 = new System.Windows.Forms.TextBox();
            this.TxtSınav3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtOrt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.TxtDurum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtOrt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtProje);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtSınav3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtSınav2);
            this.groupBox1.Controls.Add(this.cmbDersler);
            this.groupBox1.Controls.Add(this.TxtSınav1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1039, 254);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // TxtSınav1
            // 
            this.TxtSınav1.Location = new System.Drawing.Point(151, 136);
            this.TxtSınav1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSınav1.Name = "TxtSınav1";
            this.TxtSınav1.Size = new System.Drawing.Size(259, 36);
            this.TxtSınav1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sınav2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders :";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(151, 33);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(259, 36);
            this.TxtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Öğrenci id :";
            // 
            // cmbDersler
            // 
            this.cmbDersler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(151, 83);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(259, 36);
            this.cmbDersler.TabIndex = 13;
            // 
            // TxtSınav2
            // 
            this.TxtSınav2.Location = new System.Drawing.Point(151, 189);
            this.TxtSınav2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSınav2.Name = "TxtSınav2";
            this.TxtSınav2.Size = new System.Drawing.Size(259, 36);
            this.TxtSınav2.TabIndex = 14;
            // 
            // TxtSınav3
            // 
            this.TxtSınav3.Location = new System.Drawing.Point(547, 30);
            this.TxtSınav3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSınav3.Name = "TxtSınav3";
            this.TxtSınav3.Size = new System.Drawing.Size(259, 36);
            this.TxtSınav3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sınav3 :";
            // 
            // TxtProje
            // 
            this.TxtProje.Location = new System.Drawing.Point(547, 87);
            this.TxtProje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtProje.Name = "TxtProje";
            this.TxtProje.Size = new System.Drawing.Size(259, 36);
            this.TxtProje.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Proje :";
            // 
            // TxtOrt
            // 
            this.TxtOrt.Location = new System.Drawing.Point(547, 137);
            this.TxtOrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtOrt.Name = "TxtOrt";
            this.TxtOrt.Size = new System.Drawing.Size(259, 36);
            this.TxtOrt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ortalama :";
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(547, 187);
            this.TxtDurum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(259, 36);
            this.TxtDurum.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Durum :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(878, 36);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(123, 36);
            this.btnHesapla.TabIndex = 23;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(878, 86);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 36);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(878, 136);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(123, 36);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(878, 189);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(123, 36);
            this.btnAra.TabIndex = 26;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmSınavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1057, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSınavNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSınavNotlar";
            this.Load += new System.EventHandler(this.FrmSınavNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtOrt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtProje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSınav3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSınav2;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.TextBox TxtSınav1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnAra;
    }
}