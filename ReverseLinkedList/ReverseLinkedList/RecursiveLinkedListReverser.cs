using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class RecursiveLinkedListReverser : ILinkedListReverser
    {
        public Node ReverseList(Node root)
        {
            if (root == null) return null;
            if (root.Next == null) return root;
            Node next = root.Next;
            root.Next = null;
            Node reverse = ReverseList(next);
            next.Next = root;
            return reverse;
        }
    }
}
