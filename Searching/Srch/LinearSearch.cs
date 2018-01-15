using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srch
{
    public class LinearSearch: SearchBase
    {
        public override int Search(int[] items, int searchKey)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == searchKey)
                    return i;
            }
            return -1;
        }
    }
}
