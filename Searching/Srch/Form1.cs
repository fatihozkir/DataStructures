using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Srch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] RandomDiziOlustur(int count)
        {
            int[] dizi = new int[count];
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                dizi[i] = r.Next(-100, 100);
            }

            return dizi;
        }

        private void DiziyiYazdir(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                txtOnce.Text += "dizi[" + i + "] = " + dizi[i] + Environment.NewLine; 
            }
        }
        private void btnLinearSearch_Click(object sender, EventArgs e)
        {
            int[] dizi = RandomDiziOlustur(100);
            DiziyiYazdir(dizi);

            LinearSearch ls = new LinearSearch();
            int indis = ls.Search(dizi, Convert.ToInt32( txtArananSayi.Text));

            if (indis == -1)
                MessageBox.Show("Aranan sayı bulunamadı...");
            else
                MessageBox.Show("Arana sayı bulundu, dizi indisi: " + indis);

        }

        private void txtOnce_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnbinarySearch_Click(object sender, EventArgs e)
        {
            int[] dizi = {4, 7, 8, 10, 14, 21, 22, 36, 62, 77, 81, 91};

            BinarySearch BS = new BinarySearch();
            int indis = BS.Search(dizi, Convert.ToInt32(txtArananSayi.Text));

            if (indis == -1)
                MessageBox.Show("Aranan sayı bulunamadı...");
            else
                MessageBox.Show("Arana sayı bulundu, dizi indisi: " + indis);

        }
    }
}
