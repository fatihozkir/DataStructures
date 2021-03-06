﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İkiliAgac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBT_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            //kök düğümü oluştur
            İkiliAgacDugumu kok = new İkiliAgacDugumu(4);

            //***köke sağ çocuk ekle
            kok.sag = new İkiliAgacDugumu(12);
            //kökün sağ çocuğuna, sağ çocuk ekle(1)
            kok.sag.sag = new İkiliAgacDugumu(1);
            //kökün sağ çocuğuna, sol çocuk ekle(7)
            kok.sag.sol = new İkiliAgacDugumu(7);

            //***köke sol çocuk ekle (6), 
            kok.sol = new İkiliAgacDugumu(6);
            //sonra eklediğin sol çocuğa bir sol çocuk ekle (45)
            kok.sol.sol = new İkiliAgacDugumu(45);

            MessageBox.Show("İkili düğümler kullanılarak ağaç oluşturuldu.");
        }

        İkiliAgac iAgac;
        private void btnİkiliAgacOlusturGezinmeİcin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            //kök düğümü oluştur
            İkiliAgacDugumu kok = new İkiliAgacDugumu("A");

            //***köke sağ çocuk ekle
            kok.sag = new İkiliAgacDugumu("K");
            //kökün sağ çocuğuna, sağ çocuk ekle("X")
            kok.sag.sag = new İkiliAgacDugumu("X");
            //kökün sağ çocuğuna, sol çocuk ekle("L")
            kok.sag.sol = new İkiliAgacDugumu("L");
            //kökün X torununa, sağ çocuk ekle("P")
            kok.sag.sag.sag = new İkiliAgacDugumu("P");


            //***köke sol çocuk ekle
            kok.sol = new İkiliAgacDugumu("B");
            //kökün sol çocuğuna, sağ çocuk ekle("H")
            kok.sol.sag = new İkiliAgacDugumu("H");
            //kökün sol çocuğuna, sol çocuk ekle("C")
            kok.sol.sol = new İkiliAgacDugumu("C");
            //kökün C torununa, sağ çocuk ekle("M")
            kok.sol.sol.sag = new İkiliAgacDugumu("M");
            //kökün C torununa, sol çocuk ekle("Q")
            kok.sol.sol.sol = new İkiliAgacDugumu("Q");

            iAgac = new İkiliAgac(kok);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (iAgac == null)
            {
                MessageBox.Show("Ağaç üzerinde dolaşmak için öncelikle ağacı oluşturmalısınız!");
            }
            else
            {
                switch (cmbTraverseType.SelectedIndex)
                {
                    case 0:
                        iAgac.PreOrder();
                        break;
                    case 1:
                        iAgac.InOrder();
                        break;
                    case 2:
                        iAgac.PostOrder();
                        break;
                    default:
                        break;
                }
                txtSonuc.Text = iAgac.DugumleriYazdir();
            }
        }

        private void btnDugumSayisi_Click(object sender, EventArgs e)
        {
            if (iAgac == null)
            {
                MessageBox.Show("Ağaç üzerinde dolaşmak için öncelikle ağacı oluşturmalısınız!");
            }
            else
            {
                MessageBox.Show(iAgac.DugumSayisi().ToString());
            }
        }

        private void btnYaprakSayisi_Click(object sender, EventArgs e)
        {
            if (iAgac == null)
            {
                MessageBox.Show("Ağaç üzerinde dolaşmak için öncelikle ağacı oluşturmalısınız!");
            }
            else
            {
                MessageBox.Show(iAgac.YaprakSayisi().ToString());
            }

        }
    }
}
