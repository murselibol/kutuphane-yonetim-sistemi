namespace Kutuphane2
{
    partial class FormAdminAnasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminAnasayfa));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mailLabel = new System.Windows.Forms.TextBox();
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cikisYap = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTarih = new System.Windows.Forms.Label();
            this.labelSaat = new System.Windows.Forms.Label();
            this.selectedBar = new System.Windows.Forms.Panel();
            this.btnYetkiliIslem = new System.Windows.Forms.Button();
            this.btnEmanetIslem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUyeIslem = new System.Windows.Forms.Button();
            this.btnKitapIslem = new System.Windows.Forms.Button();
            this.logoBtn = new System.Windows.Forms.PictureBox();
            this.mobileMenuSlider = new System.Windows.Forms.PictureBox();
            this.profilBtn = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.timerKapaMenu = new System.Windows.Forms.Timer(this.components);
            this.timerAcMenu = new System.Windows.Forms.Timer(this.components);
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.PanelTop.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileMenuSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.PanelTop.Controls.Add(this.btnMax);
            this.PanelTop.Controls.Add(this.btnNormal);
            this.PanelTop.Controls.Add(this.btnMin);
            this.PanelTop.Controls.Add(this.btnExit);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1100, 40);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1024, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 40);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.Location = new System.Drawing.Point(1024, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(40, 40);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Visible = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(987, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 40);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1060, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.panel3);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.selectedBar);
            this.PanelMenu.Controls.Add(this.btnYetkiliIslem);
            this.PanelMenu.Controls.Add(this.btnEmanetIslem);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.btnUyeIslem);
            this.PanelMenu.Controls.Add(this.btnKitapIslem);
            this.PanelMenu.Controls.Add(this.logoBtn);
            this.PanelMenu.Controls.Add(this.mobileMenuSlider);
            this.PanelMenu.Controls.Add(this.profilBtn);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 40);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 660);
            this.PanelMenu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mailLabel);
            this.panel2.Controls.Add(this.adSoyad);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 57);
            this.panel2.TabIndex = 13;
            // 
            // mailLabel
            // 
            this.mailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.mailLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailLabel.ForeColor = System.Drawing.Color.SkyBlue;
            this.mailLabel.Location = new System.Drawing.Point(72, 31);
            this.mailLabel.Multiline = true;
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(148, 20);
            this.mailLabel.TabIndex = 12;
            this.mailLabel.Text = "murselelibol@gmail.com";
            this.mailLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adSoyad
            // 
            this.adSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.adSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adSoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adSoyad.ForeColor = System.Drawing.Color.SkyBlue;
            this.adSoyad.Location = new System.Drawing.Point(72, 12);
            this.adSoyad.Multiline = true;
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(148, 20);
            this.adSoyad.TabIndex = 0;
            this.adSoyad.Text = "Mürsel Elibol";
            this.adSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cikisYap);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 581);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 35);
            this.panel3.TabIndex = 0;
            // 
            // cikisYap
            // 
            this.cikisYap.AutoSize = true;
            this.cikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisYap.ForeColor = System.Drawing.Color.SkyBlue;
            this.cikisYap.Location = new System.Drawing.Point(107, 9);
            this.cikisYap.Name = "cikisYap";
            this.cikisYap.Size = new System.Drawing.Size(65, 16);
            this.cikisYap.TabIndex = 11;
            this.cikisYap.Text = "Çıkış Yap";
            this.cikisYap.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTarih);
            this.panel1.Controls.Add(this.labelSaat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 44);
            this.panel1.TabIndex = 9;
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.labelTarih.Location = new System.Drawing.Point(78, 26);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(39, 16);
            this.labelTarih.TabIndex = 11;
            this.labelTarih.Text = "Tarih";
            // 
            // labelSaat
            // 
            this.labelSaat.AutoSize = true;
            this.labelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.labelSaat.Location = new System.Drawing.Point(84, 5);
            this.labelSaat.Name = "labelSaat";
            this.labelSaat.Size = new System.Drawing.Size(36, 16);
            this.labelSaat.TabIndex = 10;
            this.labelSaat.Text = "Saat";
            // 
            // selectedBar
            // 
            this.selectedBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.selectedBar.Location = new System.Drawing.Point(3, 159);
            this.selectedBar.Name = "selectedBar";
            this.selectedBar.Size = new System.Drawing.Size(5, 60);
            this.selectedBar.TabIndex = 0;
            // 
            // btnYetkiliIslem
            // 
            this.btnYetkiliIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiliIslem.FlatAppearance.BorderSize = 0;
            this.btnYetkiliIslem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.btnYetkiliIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiliIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYetkiliIslem.ForeColor = System.Drawing.Color.White;
            this.btnYetkiliIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnYetkiliIslem.Image")));
            this.btnYetkiliIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYetkiliIslem.Location = new System.Drawing.Point(0, 346);
            this.btnYetkiliIslem.Name = "btnYetkiliIslem";
            this.btnYetkiliIslem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnYetkiliIslem.Size = new System.Drawing.Size(220, 60);
            this.btnYetkiliIslem.TabIndex = 8;
            this.btnYetkiliIslem.Text = "             Yetkili İşlemleri";
            this.btnYetkiliIslem.UseVisualStyleBackColor = true;
            this.btnYetkiliIslem.Click += new System.EventHandler(this.btnYetkiliIslem_Click);
            // 
            // btnEmanetIslem
            // 
            this.btnEmanetIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetIslem.FlatAppearance.BorderSize = 0;
            this.btnEmanetIslem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.btnEmanetIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetIslem.ForeColor = System.Drawing.Color.White;
            this.btnEmanetIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetIslem.Image")));
            this.btnEmanetIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmanetIslem.Location = new System.Drawing.Point(0, 282);
            this.btnEmanetIslem.Name = "btnEmanetIslem";
            this.btnEmanetIslem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEmanetIslem.Size = new System.Drawing.Size(220, 60);
            this.btnEmanetIslem.TabIndex = 6;
            this.btnEmanetIslem.Text = "                 Emanet İşlemleri";
            this.btnEmanetIslem.UseVisualStyleBackColor = true;
            this.btnEmanetIslem.Click += new System.EventHandler(this.btnEmanetIslem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "KÜTÜPHANESİ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "BAIBU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUyeIslem
            // 
            this.btnUyeIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeIslem.FlatAppearance.BorderSize = 0;
            this.btnUyeIslem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.btnUyeIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeIslem.ForeColor = System.Drawing.Color.White;
            this.btnUyeIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeIslem.Image")));
            this.btnUyeIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeIslem.Location = new System.Drawing.Point(0, 221);
            this.btnUyeIslem.Name = "btnUyeIslem";
            this.btnUyeIslem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUyeIslem.Size = new System.Drawing.Size(220, 60);
            this.btnUyeIslem.TabIndex = 3;
            this.btnUyeIslem.Text = "              Üye İşlemleri";
            this.btnUyeIslem.UseVisualStyleBackColor = true;
            this.btnUyeIslem.Click += new System.EventHandler(this.btnUyeIslem_Click);
            // 
            // btnKitapIslem
            // 
            this.btnKitapIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapIslem.FlatAppearance.BorderSize = 0;
            this.btnKitapIslem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.btnKitapIslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapIslem.ForeColor = System.Drawing.Color.White;
            this.btnKitapIslem.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapIslem.Image")));
            this.btnKitapIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitapIslem.Location = new System.Drawing.Point(0, 159);
            this.btnKitapIslem.Name = "btnKitapIslem";
            this.btnKitapIslem.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnKitapIslem.Size = new System.Drawing.Size(220, 60);
            this.btnKitapIslem.TabIndex = 2;
            this.btnKitapIslem.Text = "              Kitap İşlemleri";
            this.btnKitapIslem.UseVisualStyleBackColor = true;
            this.btnKitapIslem.Click += new System.EventHandler(this.btnKitapIslem_Click);
            // 
            // logoBtn
            // 
            this.logoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(0, 65);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logoBtn.Size = new System.Drawing.Size(220, 100);
            this.logoBtn.TabIndex = 1;
            this.logoBtn.TabStop = false;
            this.logoBtn.Click += new System.EventHandler(this.logoBtn_Click_1);
            // 
            // mobileMenuSlider
            // 
            this.mobileMenuSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mobileMenuSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mobileMenuSlider.Image = ((System.Drawing.Image)(resources.GetObject("mobileMenuSlider.Image")));
            this.mobileMenuSlider.Location = new System.Drawing.Point(153, 0);
            this.mobileMenuSlider.Name = "mobileMenuSlider";
            this.mobileMenuSlider.Size = new System.Drawing.Size(50, 50);
            this.mobileMenuSlider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mobileMenuSlider.TabIndex = 0;
            this.mobileMenuSlider.TabStop = false;
            this.mobileMenuSlider.Click += new System.EventHandler(this.mobileMenuSlider_Click);
            // 
            // profilBtn
            // 
            this.profilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilBtn.FlatAppearance.BorderSize = 0;
            this.profilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))));
            this.profilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profilBtn.ForeColor = System.Drawing.Color.White;
            this.profilBtn.Image = ((System.Drawing.Image)(resources.GetObject("profilBtn.Image")));
            this.profilBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profilBtn.Location = new System.Drawing.Point(0, 412);
            this.profilBtn.Name = "profilBtn";
            this.profilBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.profilBtn.Size = new System.Drawing.Size(220, 60);
            this.profilBtn.TabIndex = 14;
            this.profilBtn.Text = "              Profil İşlemleri";
            this.profilBtn.UseVisualStyleBackColor = true;
            this.profilBtn.Click += new System.EventHandler(this.profilBtn_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(220, 40);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(880, 660);
            this.PanelContent.TabIndex = 2;
            // 
            // timerKapaMenu
            // 
            this.timerKapaMenu.Interval = 40;
            this.timerKapaMenu.Tick += new System.EventHandler(this.timerKapaMenu_Tick);
            // 
            // timerAcMenu
            // 
            this.timerAcMenu.Interval = 40;
            this.timerAcMenu.Tick += new System.EventHandler(this.timerAcMenu_Tick);
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // FormAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileMenuSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.PictureBox mobileMenuSlider;
        private System.Windows.Forms.Timer timerKapaMenu;
        private System.Windows.Forms.Timer timerAcMenu;
        private System.Windows.Forms.Button btnKitapIslem;
        private System.Windows.Forms.PictureBox logoBtn;
        private System.Windows.Forms.Button btnUyeIslem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmanetIslem;
        private System.Windows.Forms.Panel selectedBar;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Button btnYetkiliIslem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label labelSaat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cikisYap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox mailLabel;
        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.Button profilBtn;
    }
}

