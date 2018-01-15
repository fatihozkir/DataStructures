using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTypedQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimpleQueueTest_Click(object sender, EventArgs e)
        {
            SimpleArrayTypedQueue sq = new SimpleArrayTypedQueue(5);
            sq.Insert('A');
            sq.Insert('B');
            sq.Insert('C');
            sq.Remove();
            sq.Remove();
            sq.Insert('D');
            sq.Insert('E');
            sq.Insert('F');
        }

        private void btnCircular_Click(object sender, EventArgs e)
        {
            CircularArrayTypedQueue cq = new CircularArrayTypedQueue(5);
            cq.Insert('A');
            cq.Insert('B');
            cq.Insert('C');
            cq.Remove();
            cq.Remove();
            cq.Insert('D');
            cq.Insert('E');
            cq.Insert('F');
            cq.Remove();
            cq.Insert('G');
            cq.Remove();
            cq.Remove();
            cq.Remove();
        }

        private void btnPriorityQueue_Click(object sender, EventArgs e)
        {
            PriorityQueue pq = new PriorityQueue(5);
            pq.Insert(33);
            pq.Insert(55);
            pq.Insert(11);
            pq.Insert(44);
            MessageBox.Show(pq.Remove().ToString());
            pq.Insert(22);
            MessageBox.Show(pq.Peek().ToString());
        }

        
    }
}
