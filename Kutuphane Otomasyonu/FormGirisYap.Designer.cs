namespace Kutuphane2
{
    partial class FormGirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGirisYap));
            this.girisBtn = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.radioAdmin = new System.Windows.Forms.RadioButton();
            this.radioKullanici = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sifUnutBtn = new System.Windows.Forms.Label();
            this.kAdi = new System.Windows.Forms.TextBox();
            this.errMessage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisBtn
            // 
            this.girisBtn.BackColor = System.Drawing.Color.Black;
            this.girisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisBtn.FlatAppearance.BorderSize = 0;
            this.girisBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(27)))));
            this.girisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.girisBtn.ForeColor = System.Drawing.Color.White;
            this.girisBtn.Location = new System.Drawing.Point(63, 301);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(260, 40);
            this.girisBtn.TabIndex = 5;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.sifre.Location = new System.Drawing.Point(99, 187);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(220, 30);
            this.sifre.TabIndex = 2;
            this.sifre.Text = "Şifre";
            this.sifre.Enter += new System.EventHandler(this.sifre_Enter);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // radioAdmin
            // 
            this.radioAdmin.AutoSize = true;
            this.radioAdmin.Location = new System.Drawing.Point(114, 250);
            this.radioAdmin.Name = "radioAdmin";
            this.radioAdmin.Size = new System.Drawing.Size(54, 17);
            this.radioAdmin.TabIndex = 3;
            this.radioAdmin.TabStop = true;
            this.radioAdmin.Text = "Admin";
            this.radioAdmin.UseVisualStyleBackColor = true;
            // 
            // radioKullanici
            // 
            this.radioKullanici.AutoSize = true;
            this.radioKullanici.Location = new System.Drawing.Point(216, 250);
            this.radioKullanici.Name = "radioKullanici";
            this.radioKullanici.Size = new System.Drawing.Size(64, 17);
            this.radioKullanici.TabIndex = 4;
            this.radioKullanici.TabStop = true;
            this.radioKullanici.Text = "Kullanıcı";
            this.radioKullanici.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(94, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 8;
            // 
            // sifUnutBtn
            // 
            this.sifUnutBtn.AutoSize = true;
            this.sifUnutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifUnutBtn.Location = new System.Drawing.Point(154, 411);
            this.sifUnutBtn.Name = "sifUnutBtn";
            this.sifUnutBtn.Size = new System.Drawing.Size(81, 13);
            this.sifUnutBtn.TabIndex = 6;
            this.sifUnutBtn.Text = "Şifremi Unuttum";
            // 
            // kAdi
            // 
            this.kAdi.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.kAdi.Location = new System.Drawing.Point(99, 118);
            this.kAdi.Multiline = true;
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(220, 30);
            this.kAdi.TabIndex = 1;
            this.kAdi.Text = "E-Mail";
            this.kAdi.Enter += new System.EventHandler(this.kAdi_Enter);
            this.kAdi.Leave += new System.EventHandler(this.kAdi_Leave);
            // 
            // errMessage
            // 
            this.errMessage.AutoSize = true;
            this.errMessage.ForeColor = System.Drawing.Color.Red;
            this.errMessage.Location = new System.Drawing.Point(127, 358);
            this.errMessage.Name = "errMessage";
            this.errMessage.Size = new System.Drawing.Size(144, 13);
            this.errMessage.TabIndex = 8;
            this.errMessage.Text = "Kullanıcı Adı veya Şifre Hatalı";
            this.errMessage.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 475);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(389, 3);
            this.panel3.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(389, 40);
            this.panel5.TabIndex = 0;
            
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(349, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 435);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(386, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 435);
            this.panel4.TabIndex = 12;
            // 
            // FormGirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 478);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sifUnutBtn);
            this.Controls.Add(this.errMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kAdi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioKullanici);
            this.Controls.Add(this.radioAdmin);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.girisBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGirisYap";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.RadioButton radioAdmin;
        private System.Windows.Forms.RadioButton radioKullanici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label sifUnutBtn;
        private System.Windows.Forms.TextBox kAdi;
        private System.Windows.Forms.Label errMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}