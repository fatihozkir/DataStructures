using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2.Abstract
{
    public abstract class QueueBase
    {
        protected object[] Dizi { get; set; }
        protected int bas=0, son=0,count=0,boyut=0;
        public abstract void EnQueue(object data);
        public abstract object DeQueue();
        public abstract object Peek();
        public abstract bool IsEmpty();
    }
}
