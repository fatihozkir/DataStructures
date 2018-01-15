using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Soru2.Abstract;

namespace Soru2.Concrete
{
    public class CircularQueue:QueueBase
    {
        public CircularQueue(int Boyut)
        {
            this.boyut = Boyut;
            this.Dizi=new object[Boyut];
        }
        public override void EnQueue(object data)
        {
            if (count==boyut)
            {
                throw new Exception("Kuyruk Dolu !");
            }
            if (son==boyut)
            {
                son = 0;
                Dizi[son++] = data;
            }
            else
                Dizi[son++] = data;
            count++;
        }

        public override object DeQueue()
        {
            object returnElement = null;
            if (IsEmpty() || bas == son) throw new Exception("Kuyruk Boş !");
            if (bas == son)
            {
                bas = 0;
                returnElement = Dizi[bas];
                Dizi[bas++] = null;
            }
            else
            {
                returnElement = Dizi[bas];
                Dizi[bas++] = null;
            }
            count--;
            return returnElement;
        }

        public override object Peek()
        {
            return Dizi[son-1];
        }

        public override bool IsEmpty()
        {
            return count == 0;
        }
    }
}
