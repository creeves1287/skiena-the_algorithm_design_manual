using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class LinkedListReverser : ILinkedListReverser
    {
        public Node ReverseList(Node root)
        {
            if (root == null) return null;
            if (root.Next == null) return root;
            Node previous = null;
            while (root != null)
            {
                Node next = root.Next;
                root.Next = previous;
                previous = root;
                root = next;
            }
            return previous;
        }
    }
}
