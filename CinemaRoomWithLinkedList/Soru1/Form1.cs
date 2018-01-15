using System;
using System.Collections;
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
    public partial class FrmSalon : Form
    {
        public FrmSalon()
        {
            InitializeComponent();
        }

        private int x = 40, y = 40, koltukNo = 0;
        public static LinkedList liste = new LinkedList();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                liste.InsertPosition(new Koltuk {AdSoyad = null,KoltukNo = i}, i);
            }
            lblBosSayi.Text = liste.Count.ToString();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Button koltukButon = new Button();
                    koltukButon.Name = "KoltukNo" + koltukNo;
                    koltukButon.Text = koltukNo.ToString();
                    koltukButon.Size = new Size(40, 40);
                    koltukButon.Left = x;
                    koltukButon.BackColor = System.Drawing.Color.LimeGreen;
                    x += 60;
                    koltukButon.Top = y;
                    koltukNo++;
                    //Koltuklara Tıklandığı Zaman Ne İşlem Yapılacağını Gösteriyoruz.
                    koltukButon.Click += new EventHandler(koltukButon_Click);
                    Koltuklar.Controls.Add(koltukButon);
                }
                x = 40;
                y += 60;
            }
        }

        public Button btn;
        void koltukButon_Click(object sender, EventArgs e)
        {
            btn = sender as Button;
            Rezervasyon frmRezervasyon=new Rezervasyon();
            string secilenKoltuk = btn.Text;
            frmRezervasyon.txtKoltukNo.Text = secilenKoltuk;
            frmRezervasyon.ShowDialog();

        }
    }
}

