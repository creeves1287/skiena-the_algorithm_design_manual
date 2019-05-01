using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTToLinkedList
{
    public class BSTToLinkedListConverterWithStack : IBSTToLinkedListConverter
    {
        public LinkedListNode Convert(TreeNode root)
        {
            if (root == null) return null;
            Stack<int> values = new Stack<int>();
            BuildStack(root, values);
            LinkedListNode head = CreateList(values);
            return head;
        }

        private void BuildStack(TreeNode root, Stack<int> values)
        {
            if (root == null) return;
            BuildStack(root.Left, values);
            values.Push(root.Value);
            BuildStack(root.Right, values);
        }

        private LinkedListNode CreateList(Stack<int> values)
        {
            LinkedListNode head = null;
            while (values.Count > 0)
            {
                LinkedListNode current = new LinkedListNode(values.Pop());
                current.Next = head;
                head = current;
            }
            return head;
        }
    }
}
