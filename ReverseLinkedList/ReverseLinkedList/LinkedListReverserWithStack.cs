using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    public class LinkedListReverserWithStack : ILinkedListReverser
    {
        public Node ReverseList(Node root)
        {
            if (root == null) return null;
            if (root.Next == null) return root;
            Stack<Node> nodes = CreateNodeStack(root);
            root = nodes.Peek();
            while (nodes.Count > 0)
            {
                Node node = nodes.Pop();
                if (nodes.Count > 0)
                {
                    node.Next = nodes.Peek();
                }
                else
                {
                    node.Next = null;
                }
            }
            return root;
        }

        private Stack<Node> CreateNodeStack(Node root)
        {
            Stack<Node> nodes = new Stack<Node>();
            Node node = root;
            while (node != null)
            {
                nodes.Push(node);
                node = node.Next;
            }
            return nodes;
        }
    }
}
