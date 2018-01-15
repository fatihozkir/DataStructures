using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soru2.Concrete;

namespace Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        CircularQueue donguselKuyruk = new CircularQueue(20);
        PriorityQueue oncelikKuyruk = new PriorityQueue(20);
        private void btnCircular_Click(object sender, EventArgs e)
        {
            #region islemKodlari
            lstDongusel.Items.Clear();
            int musteriNo, islemSuresi, toplamSure = 0;
            bool secim = true;
            Random rnd=new Random();
            for (int i = 0; i < 20; i++)
            {
                musteriNo = rnd.Next(1, 1000);
                islemSuresi = rnd.Next(60, 600);
                Kisi k=new Kisi {IslemSuresi = islemSuresi,MusteriNo = musteriNo};
                toplamSure += k.IslemSuresi;
                donguselKuyruk.EnQueue(k);
                ListViewItem li = new ListViewItem(k.MusteriNo.ToString());
                li.SubItems.Add(toplamSure.ToString());
                lstDongusel.Items.Add(li);
            }
            lblDonguselToplam.Text = "Kuyruk Toplam Süre: " + toplamSure;
            lblDonguselOrtalama.Text = "Her Müşterinin Ortalama Bekleme Süresi: " + (toplamSure / 20);
            DialogResult sonuc =  MessageBox.Show("Kuyruğun İşlem Süresi Baz Alınarak Sıralı Halini Görmek İçin"+Environment.NewLine+ "Küçükten Büyüğe Görmek İstiyorsanız -> Evet" +Environment.NewLine+ "Büyükten Küçüğe Görmek İstiyorsanız -> Hayır" + Environment.NewLine+"Seçeneğini Kullanınız !","Uyarı !",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (sonuc==DialogResult.Yes)
            {
                OncelikKuyruguKucuktenBuyuge();
                lblAnaliz.Text ="Dairesel Kuyrukta Geçen Süre ve Küçükten Büyüğe İşlem Önceliğindeki Sürenin Karşılaştırılması Sonucu Yapılan Analiz Sonuçları:";
            }
            else
            {
                OncelikKuyruguBuyuktenKucuge();
                lblAnaliz.Text = "Dairesel Kuyrukta Geçen Süre ve Büyükten Küçüğe İşlem Önceliğindeki Sürenin Karşılaştırılması Sonucu Yapılan Analiz Sonuçları:";
                secim = false;
            }
            #endregion
            #region AnalizKodlari
            if (secim)
            {
                AnalizYap(lstDongusel, lstOncelik, lstAnaliz);
            }
            else
            {
                AnalizYap(lstDongusel, lstOncelik1, lstAnaliz);
            }
            
            #endregion
        }

        #region Metodlar
        private void AnalizYap(ListView lst1,ListView lst2,ListView lst3)
        {
            foreach (ListViewItem itemliste1 in lst1.Items)
            {
                foreach (ListViewItem itemListe2 in lst2.Items)
                {
                    if (itemliste1.Text != itemListe2.Text) continue;
                    ListViewItem li = new ListViewItem(itemliste1.Text);
                    li.SubItems.Add(itemliste1.SubItems[1].Text);
                    li.SubItems.Add(itemListe2.SubItems[1].Text);
                    li.SubItems.Add("0");
                    li.SubItems.Add("0");
                    lstAnaliz.Items.Add(li);
                }
            }

            foreach (ListViewItem itemListe3 in lst3.Items)
            {
                decimal donguselSure = int.Parse(itemListe3.SubItems[1].Text);
                decimal oncelikliSure = int.Parse(itemListe3.SubItems[2].Text);
                itemListe3.SubItems[3].Text = Math.Abs(donguselSure - oncelikliSure)+" sn";
                itemListe3.SubItems[4].Text = "% "+(Math.Abs(donguselSure - oncelikliSure) / 100) + " performans";

            }
        }
        private void OncelikKuyruguKucuktenBuyuge()
        {
            int toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                Kisi k = (Kisi)donguselKuyruk.DeQueue();
                oncelikKuyruk.EnQueue(k);
            }
            for (int i = 0; i < 20; i++)
            {
                Kisi k = (Kisi)oncelikKuyruk.DeQueue();
                toplamSure += k.IslemSuresi;
                ListViewItem li = new ListViewItem(k.MusteriNo.ToString());
                li.SubItems.Add(toplamSure.ToString());
                lstOncelik.Items.Add(li);
            }
            lblOncelik0Ortalama.Text = "Her Müşterinin Ortalama Bekleme Süresi: " + (toplamSure / 20);
            lblOncelik0ToplamSure.Text = "Kuyruk Toplam Süre: " + toplamSure;
        }
        private void OncelikKuyruguBuyuktenKucuge()
        {
            
            int toplamSure = 0;
            for (int i = 0; i < 20; i++)
            {
                Kisi k = (Kisi)donguselKuyruk.DeQueue();
                oncelikKuyruk.EnQueueBuyuktenKucuge(k);
            }
            for (int i = 0; i < 20; i++)
            {
                Kisi k = (Kisi)oncelikKuyruk.DeQueue();
                toplamSure += k.IslemSuresi;
                ListViewItem li = new ListViewItem(k.MusteriNo.ToString());
                li.SubItems.Add(toplamSure.ToString());
                lstOncelik1.Items.Add(li);
            }
            lblOncelik1Ortalama.Text = "Her Müşterinin Ortalama Bekleme Süresi: " + (toplamSure / 20);
            lblOncelik1ToplamSure.Text = "Kuyruk Toplam Süre: " + toplamSure;
        }
        #endregion
    }
}
