using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTToLinkedList
{
    public class LinkedListNode
    {
        public LinkedListNode(int data)
        {
            Value = data;
        }
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }
    }
}
