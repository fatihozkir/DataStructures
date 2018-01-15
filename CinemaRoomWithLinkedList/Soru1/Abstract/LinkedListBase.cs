using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soru1.Concrete;

namespace Soru1.Abstract
{
    public abstract class LinkedListBase
    {
        //Burada Head düğümünün Yalnızca Bir Kere instance oluşmunu sağlayarak her şeyin tek bir Head düğümü üzerinden işlem yapılmasını sağladım.
        private static Node head;
        public  Node Head
        {
            get { return (head ?? (head = new Node())); }
            set { head = value; }
        }
        public int Count { get; set; }
        public abstract void InsertPosition(object data, int position);
        public abstract void DeletePosition(int position);
        public abstract Node GetElement(int position);
    }
}
