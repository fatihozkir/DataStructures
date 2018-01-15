using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class frmSorting : Form
    {
        public frmSorting()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] dizi = {5, 1, 12, -5, 16};
            BubbleSort bs = new BubbleSort();
            txtOnce.Text = bs.PrintItems(dizi);
            bs.Sort(dizi);
            txtSonra.Text = bs.PrintItems(dizi);
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            int[] dizi = { 7, 4, 5, 9, 8, 2, 1 };
            SelectionSort ss = new SelectionSort();
            txtOnce.Text = ss.PrintItems(dizi);
            ss.Sort(dizi);
            txtSonra.Text = ss.PrintItems(dizi);

        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            int[] dizi = { 65, 50, 30, 35, 25, 45};            
            InsertionSort ins = new InsertionSort();
            txtOnce.Text = ins.PrintItems(dizi);
            ins.Sort(dizi);
            txtSonra.Text = ins.PrintItems(dizi);
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            int[] dizi = { 2, 17, -4, 42, 9, 26, 11, 3, 5, 28 };
            QuickSort QS = new QuickSort();
            txtOnce.Text = QS.PrintItems(dizi);
            QS.Sort(dizi);
            txtSonra.Text = QS.PrintItems(dizi);

        }
    }
}
