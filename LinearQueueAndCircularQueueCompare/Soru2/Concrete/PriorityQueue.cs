using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soru2.Abstract;

namespace Soru2.Concrete
{
    public class PriorityQueue:QueueBase
    {
        public PriorityQueue(int Boyut)
        {
            this.boyut = Boyut;
            this.Dizi = new object[Boyut];
        }
        public override void EnQueue(object data)
        {
            if (count == boyut) throw new Exception("Kuyruk Dolu !");
            int i = 0;
            if (son == boyut)
            {
                son = 0;
                Dizi[son] = 0;
            }
            else
            {
                Kisi kisiData = (Kisi) data;
                for (i = count - 1; i >= 0; i--)
                {
                    Kisi diziKisiData = (Kisi) Dizi[i];
                    if (kisiData.IslemSuresi <diziKisiData.IslemSuresi )
                    {
                        Dizi[i + 1] = Dizi[i];
                    }
                    else break;
                }
                Dizi[i + 1] = data;
            }

            son++;
            count++;
        }
        public void EnQueueBuyuktenKucuge(object data)
        {
            if (count == boyut) throw new Exception("Kuyruk Dolu !");
            int i = 0;
            if (son == boyut)
            {
                son = 0;
                Dizi[son] = 0;
            }
            else
            {
                Kisi kisiData = (Kisi)data;
                for (i = count - 1; i >= 0; i--)
                {
                    Kisi diziKisiData = (Kisi)Dizi[i];
                    if (kisiData.IslemSuresi > diziKisiData.IslemSuresi)
                    {
                        Dizi[i + 1] = Dizi[i];
                    }
                    else break;
                }
                Dizi[i + 1] = data;
            }

            son++;
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
