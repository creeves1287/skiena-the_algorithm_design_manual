using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public int Data { get; set; }
        public Node(int data)
        {
            Data = data;
        }
        public Node() { }

    }
}
