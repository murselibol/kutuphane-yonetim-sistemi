namespace Kutuphane2
{
    partial class FormKitapIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriEkleBtn = new System.Windows.Forms.Label();
            this.kategoriCombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.aciklamaTxt = new System.Windows.Forms.TextBox();
            this.fotografPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.kitapAraTxt = new System.Windows.Forms.TextBox();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sayfaSayisiTxt = new System.Windows.Forms.TextBox();
            this.yayinEviTxt = new System.Windows.Forms.TextBox();
            this.baskiYiliTxt = new System.Windows.Forms.TextBox();
            this.yazarTxt = new System.Windows.Forms.TextBox();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.btnISBN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotografPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnResim);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.kategoriEkleBtn);
            this.panel1.Controls.Add(this.kategoriCombobox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.aciklamaTxt);
            this.panel1.Controls.Add(this.fotografPic);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.kitapAraTxt);
            this.panel1.Controls.Add(this.btnDüzenle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sayfaSayisiTxt);
            this.panel1.Controls.Add(this.yayinEviTxt);
            this.panel1.Controls.Add(this.baskiYiliTxt);
            this.panel1.Controls.Add(this.yazarTxt);
            this.panel1.Controls.Add(this.adTxt);
            this.panel1.Controls.Add(this.btnISBN);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 660);
            this.panel1.TabIndex = 0;
            // 
            // btnResim
            // 
            this.btnResim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResim.Location = new System.Drawing.Point(98, 302);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(77, 23);
            this.btnResim.TabIndex = 146;
            this.btnResim.Text = "Resim Seç";
            this.btnResim.UseVisualStyleBackColor = true;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(265, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(597, 546);
            this.dataGridView1.TabIndex = 145;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // kategoriEkleBtn
            // 
            this.kategoriEkleBtn.AutoSize = true;
            this.kategoriEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kategoriEkleBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.kategoriEkleBtn.Location = new System.Drawing.Point(97, 184);
            this.kategoriEkleBtn.Name = "kategoriEkleBtn";
            this.kategoriEkleBtn.Size = new System.Drawing.Size(70, 13);
            this.kategoriEkleBtn.TabIndex = 100;
            this.kategoriEkleBtn.Text = "Kategori Ekle";
            this.kategoriEkleBtn.Click += new System.EventHandler(this.kategoriEkleBtn_Click);
            // 
            // kategoriCombobox
            // 
            this.kategoriCombobox.FormattingEnabled = true;
            this.kategoriCombobox.Location = new System.Drawing.Point(98, 160);
            this.kategoriCombobox.Name = "kategoriCombobox";
            this.kategoriCombobox.Size = new System.Drawing.Size(137, 21);
            this.kategoriCombobox.TabIndex = 32;
            this.kategoriCombobox.Click += new System.EventHandler(this.kategoriCombobox_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Kategori :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Açıklama :";
            // 
            // aciklamaTxt
            // 
            this.aciklamaTxt.Location = new System.Drawing.Point(98, 455);
            this.aciklamaTxt.Multiline = true;
            this.aciklamaTxt.Name = "aciklamaTxt";
            this.aciklamaTxt.Size = new System.Drawing.Size(137, 71);
            this.aciklamaTxt.TabIndex = 37;
            // 
            // fotografPic
            // 
            this.fotografPic.BackColor = System.Drawing.SystemColors.Info;
            this.fotografPic.Location = new System.Drawing.Point(96, 335);
            this.fotografPic.Name = "fotografPic";
            this.fotografPic.Size = new System.Drawing.Size(79, 107);
            this.fotografPic.TabIndex = 50;
            this.fotografPic.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Fotoğraf :";
            // 
            // btnAra
            // 
            this.btnAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(764, 60);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(98, 36);
            this.btnAra.TabIndex = 40;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // kitapAraTxt
            // 
            this.kitapAraTxt.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAraTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.kitapAraTxt.Location = new System.Drawing.Point(265, 65);
            this.kitapAraTxt.Multiline = true;
            this.kitapAraTxt.Name = "kitapAraTxt";
            this.kitapAraTxt.Size = new System.Drawing.Size(493, 20);
            this.kitapAraTxt.TabIndex = 39;
            this.kitapAraTxt.Text = "Kitap Adı, Yazar Adı, ISBN, Kategori Adı";
            this.kitapAraTxt.Enter += new System.EventHandler(this.kitapAraTxt_Enter);
            this.kitapAraTxt.Leave += new System.EventHandler(this.kitapAraTxt_Leave);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDüzenle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnDüzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.btnDüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDüzenle.Location = new System.Drawing.Point(41, 597);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(90, 42);
            this.btnDüzenle.TabIndex = 41;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(146, 597);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 42);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(41, 546);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(194, 42);
            this.btnKaydet.TabIndex = 38;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Sayfa Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Yayın Evi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Baskı Yılı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Yazar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kitap Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ISBN : ";
            // 
            // sayfaSayisiTxt
            // 
            this.sayfaSayisiTxt.Location = new System.Drawing.Point(98, 269);
            this.sayfaSayisiTxt.Multiline = true;
            this.sayfaSayisiTxt.Name = "sayfaSayisiTxt";
            this.sayfaSayisiTxt.Size = new System.Drawing.Size(137, 20);
            this.sayfaSayisiTxt.TabIndex = 35;
            // 
            // yayinEviTxt
            // 
            this.yayinEviTxt.Location = new System.Drawing.Point(98, 238);
            this.yayinEviTxt.Multiline = true;
            this.yayinEviTxt.Name = "yayinEviTxt";
            this.yayinEviTxt.Size = new System.Drawing.Size(137, 20);
            this.yayinEviTxt.TabIndex = 34;
            // 
            // baskiYiliTxt
            // 
            this.baskiYiliTxt.Location = new System.Drawing.Point(98, 207);
            this.baskiYiliTxt.Multiline = true;
            this.baskiYiliTxt.Name = "baskiYiliTxt";
            this.baskiYiliTxt.Size = new System.Drawing.Size(137, 20);
            this.baskiYiliTxt.TabIndex = 33;
            // 
            // yazarTxt
            // 
            this.yazarTxt.Location = new System.Drawing.Point(98, 128);
            this.yazarTxt.Multiline = true;
            this.yazarTxt.Name = "yazarTxt";
            this.yazarTxt.Size = new System.Drawing.Size(137, 20);
            this.yazarTxt.TabIndex = 31;
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(98, 97);
            this.adTxt.Multiline = true;
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(137, 20);
            this.adTxt.TabIndex = 30;
            // 
            // btnISBN
            // 
            this.btnISBN.Location = new System.Drawing.Point(98, 66);
            this.btnISBN.Multiline = true;
            this.btnISBN.Name = "btnISBN";
            this.btnISBN.Size = new System.Drawing.Size(137, 20);
            this.btnISBN.TabIndex = 29;
            // 
            // FormKitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 660);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKitapIslemleri";
            this.Text = "FormKitapIslemleri";
            this.Load += new System.EventHandler(this.FormKitapIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotografPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox kategoriCombobox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox aciklamaTxt;
        private System.Windows.Forms.PictureBox fotografPic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayfaSayisiTxt;
        private System.Windows.Forms.TextBox yayinEviTxt;
        private System.Windows.Forms.TextBox baskiYiliTxt;
        private System.Windows.Forms.TextBox yazarTxt;
        private System.Windows.Forms.TextBox adTxt;
        private System.Windows.Forms.TextBox btnISBN;
        private System.Windows.Forms.Label kategoriEkleBtn;
        private System.Windows.Forms.TextBox kitapAraTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnResim;
    }
}