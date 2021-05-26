using System;
using System.Runtime.InteropServices; // Uygulamayı yukardan tutup süreklemek için
using System.Windows.Forms;

namespace Kutuphane2
{
    public partial class FormAdminAnasayfa : Form
    {
        public FormAdminAnasayfa()
        {

            InitializeComponent();
        }

        static public string alAdSoyad;
        static public string mail;


        private void Form1_Load(object sender, EventArgs e)
        {
            adSoyad.Text = alAdSoyad;
            mailLabel.Text = mail;
        }




        // Uygulamayı yukardan tutup istediğimiz yere sürükleme ( --> using System.Runtime.InteropServices;  )
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //------------------------------------------------------------




        // YENİ AÇILAN FORMUN PANELCONTENT İÇİNDE YER ALMASI İÇİN AYARLAMALAR
        private void AbrirFormPanel(object Formhijo)
        {
            if (this.PanelContent.Controls.Count > 0)
            {
                this.PanelContent.Controls.RemoveAt(0);
            }
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContent.Controls.Add(fh);
            this.PanelContent.Tag = fh;
            fh.Show();

        }
        //------------------------------------------------------------





        // ÇIKIŞ KÜÇÜLTME BÜYÜTME TEPSİ MODUNA ALMA
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnNormal.Visible = true;
            btnMax.Visible = false;
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMax.Visible = true;
        }
        // -----------------------------------------------------------





        // MOBILE MENU SLIDER
        private void timerKapaMenu_Tick(object sender, EventArgs e)
        {
            if (PanelMenu.Width <= 80)
            {
                this.timerKapaMenu.Enabled = false;
            }
            else
            {
                this.PanelMenu.Width = PanelMenu.Width - 20;
            }
        }
        private void timerAcMenu_Tick(object sender, EventArgs e)
        {
            if (PanelMenu.Width >= 220)
            {
                this.timerAcMenu.Enabled = false;
            }
            else
            {
                this.PanelMenu.Width = PanelMenu.Width + 20;
            }
        }
        private void mobileMenuSlider_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 220)
            {
                this.timerKapaMenu.Enabled = true;
            }
            else if (PanelMenu.Width == 80)
            {
                this.timerAcMenu.Enabled = true;
            }
        }
        // -----------------------------------------------------------




        // KİTAP İŞLEMLERİ FORMU AÇILMASI ( EKRANIN ORTASINDA )
        // SEÇİLİ OLAN BUTONDA CUBUK İŞARETİ ÇIKMASI
        private void btnKitapIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormKitapIslemleri());

            selectedBar.Visible = true;
            selectedBar.Height = btnKitapIslem.Height;
            selectedBar.Top = btnKitapIslem.Top;
        }
        private void btnUyeIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormUyeIslemleri());

            selectedBar.Visible = true;
            selectedBar.Height = btnUyeIslem.Height;
            selectedBar.Top = btnUyeIslem.Top;
        }
        private void btnEmanetIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormEmanetIslemleri());

            selectedBar.Visible = true;
            selectedBar.Height = btnEmanetIslem.Height;
            selectedBar.Top = btnEmanetIslem.Top;
        }
        private void btnYetkiliIslem_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new FormYetkiliIslemleri());
            selectedBar.Visible = true;
            selectedBar.Height = btnYetkiliIslem.Height;
            selectedBar.Top = btnYetkiliIslem.Top;
        }
        //-----------------------------------------------------------




        // LOGO CLİCK
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void logoBtn_Click_1(object sender, EventArgs e)
        {

            selectedBar.Visible = false;
        }
        // -----------------------------------------------------------





        // GÜN-SAAT ( TIMER EKLEDİK ENABLED = TRUE)
        private void timerSaat_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.ToShortDateString();
        }









        private void label5_Click(object sender, EventArgs e)
        {


            this.Close();
            FormGirisYap.obj.Visible = true;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            this.Close();
            FormGirisYap.obj.Visible = true;

        }

        private void profilBtn_Click(object sender, EventArgs e)
        {
            FormProfilAyarlari pf = new FormProfilAyarlari();
            selectedBar.Visible = true;
            selectedBar.Height = profilBtn.Height;
            selectedBar.Top = profilBtn.Top;
            pf.ShowDialog();
        }

        //--------------------------------------------------------------




    }
}
