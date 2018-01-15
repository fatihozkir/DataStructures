using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soru1.Concrete;

namespace Soru1
{
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }
        private LinkedList liste = FrmSalon.liste;
        int koltukNo = 0;
        Button btn;
        Label lblDolu;
        Label lblBos;
        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            koltukNo = int.Parse(txtKoltukNo.Text);
            Node gelenNode = liste.GetElement(koltukNo);
            Koltuk gelenKoltuk = (Koltuk)gelenNode.Data;
            if (gelenKoltuk.AdSoyad == null) return;
            MessageBox.Show("Bu Koltuğu: " + gelenKoltuk.AdSoyad + " rezerve etmiştir. Eğer rezervasyonunuzu geri almak isterseniz \"Iptal Et\" seçeneğini kullanın !", "Dikkat !",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtAdSoyad.Text = gelenKoltuk.AdSoyad;
            txtKoltukNo.Text = gelenKoltuk.KoltukNo.ToString();
        }
        private void btnAl_Click(object sender, EventArgs e)
        {
            koltukNo = int.Parse(txtKoltukNo.Text);
            Node gelenNode = liste.GetElement(koltukNo);
            Koltuk gelenKoltuk = (Koltuk) gelenNode.Data;
            if (gelenKoltuk.AdSoyad!=null)
            {
                MessageBox.Show("Bu Koltuğu: " + gelenKoltuk.AdSoyad + " rezerve etmiştir. Aynı koltuk tekrardan rezerve edilemez! Eğer rezervasyonunuzu geri almak isterseniz \"Iptal Et\" seçeneğini kullanın !", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (string.IsNullOrEmpty(txtAdSoyad.Text))
                {
                    MessageBox.Show("Lütfen isim alanını boş geçmeyin", "Uyarı !",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Koltuk k = new Koltuk { KoltukNo = koltukNo, AdSoyad = txtAdSoyad.Text };
                liste.DeletePosition(koltukNo);
                liste.InsertPosition(k, koltukNo);
                MessageBox.Show("Koltuk: "+k.AdSoyad+ "'a rezerve edilmiştir. Koltuğun mevcut durumu dolu olarak değiştirildi !", "İşlem Başarılı !",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                btn=ButonuGetir();
                btn.BackColor = System.Drawing.Color.DarkRed;
                lblDolu = DoluLabelGetir();
                lblBos = BosLabelGetir();
                int doluSayisi = int.Parse(lblDolu.Text);
                int bosSayisi = int.Parse(lblBos.Text);
                lblDolu.Text = (++doluSayisi).ToString();
                lblBos.Text = (--bosSayisi).ToString();
                this.Close();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            koltukNo = int.Parse(txtKoltukNo.Text);
            Node gelenNode = liste.GetElement(koltukNo);
            Koltuk gelenKoltuk = (Koltuk)gelenNode.Data;
            if (gelenKoltuk.AdSoyad == null) return;
            liste.DeletePosition(koltukNo);
            liste.InsertPosition(new Koltuk { AdSoyad = null, KoltukNo = koltukNo }, koltukNo);
            MessageBox.Show("Koltuk rezervasyonu iptal edilmiştir. Koltuğun mevcut durumu boş olarak değiştirildi !", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtAdSoyad.Text = string.Empty;
            btn = ButonuGetir();
            btn.BackColor = System.Drawing.Color.LimeGreen;
            lblDolu = DoluLabelGetir();
            lblBos = BosLabelGetir();
            int doluSayisi = int.Parse(lblDolu.Text);
            int bosSayisi = int.Parse(lblBos.Text);
            lblDolu.Text = (--doluSayisi).ToString();
            lblBos.Text = (++bosSayisi).ToString();
            this.Close();
        }

        #region Salon Formundaki Controllere Erisim Kodlari
        private Button ButonuGetir()
        {
            Button btnGelen = new Button();
            FrmSalon salonForm = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Fatih Özkır Salonu")
                {
                    salonForm = (FrmSalon)item;
                }
            }
            if (salonForm != null)
            {
                foreach (Control btn in salonForm.Koltuklar.Controls)
                {
                    if (btn is Button)
                    {
                        if (btn.Text == koltukNo.ToString())
                        {
                            btnGelen = (Button)btn;
                        }
                    }
                }
            }
            return btnGelen;
        }
        private Label DoluLabelGetir()
        {
            Label lblGelen = new Label();
            FrmSalon salonForm = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Fatih Özkır Salonu")
                {
                    salonForm = (FrmSalon)item;
                }
            }
            if (salonForm != null)
            {
                foreach (Control lbl in salonForm.Controls)
                {
                    if (lbl is Label)
                    {
                        if (lbl.Tag=="Dolu")
                        {
                            lblGelen = (Label)lbl;
                        }
                    }
                }
            }
            return lblGelen;
        }
        private Label BosLabelGetir()
        {
            Label lblGelen = new Label();
            FrmSalon salonForm = null;
            foreach (Form item in Application.OpenForms)
            {
                if (item.Text == "Fatih Özkır Salonu")
                {
                    salonForm = (FrmSalon)item;
                }
            }
            if (salonForm != null)
            {
                foreach (Control lbl in salonForm.Controls)
                {
                    if (lbl is Label)
                    {
                        if (lbl.Tag == "Bos")
                        {
                            lblGelen = (Label)lbl;
                        }
                    }
                }
            }
            return lblGelen;
        }
        #endregion

    }
}
