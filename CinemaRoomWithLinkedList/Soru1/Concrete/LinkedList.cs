using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soru1.Abstract;

namespace Soru1.Concrete
{
    public class LinkedList:LinkedListBase
    {
        public override void InsertPosition(object data, int position)
        {
            Node newNode = new Node { Data = data };
            if (Head==null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                Node prevNode = null;
                int i = 0;
                if (position==0)
                {
                    Head = newNode;
                    Head.Next = currentNode;
                }
                else
                {
                    while (true)
                    {
                        if (i == position) break;
                        prevNode = currentNode;
                        currentNode = currentNode.Next;
                        i++;

                    }
                    prevNode.Next = newNode;
                    newNode.Next = currentNode;
                }
                
            }

            Count++;

        }
        public override void DeletePosition(int position)
        {
            int i = 0;
            Node currentNode = Head;
            Node nextNode = currentNode.Next;
            Node prevNode = null;
            if (position==0)
            {
                Head = null;
                Head = nextNode;
                
            }
            else
            {
                while (true)
                {
                    if (i == position) break;
                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                    nextNode = currentNode.Next;
                    i++;
                }
                currentNode = null;
                prevNode.Next = null;
                prevNode.Next = nextNode;
            }
            
            Count--;
        }

        public override Node GetElement(int position)
        {
            int i = 0;
            Node currentNode = Head;
            while (true)
            {
                if (i == position) break;
                currentNode = currentNode.Next;
                i++;
            }
            return currentNode;
        }
    }
}
