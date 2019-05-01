using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTToLinkedList
{
    public class BSTToLinkedListConverterFlatten : IBSTToLinkedListConverter
    {
        /*
         *        10
         *      /    \
         *     /      \
         *    6        18
         *   / \      /  \ 
         *  3   9    14  21
         *  
         *  [3, 6, 9, 10, 14, 18, 21]
         * */

        public LinkedListNode Convert(TreeNode root)
        {
            root = ConvertHelper(root);
            LinkedListNode head = ConvertToLinkedList(root);
            return head;
        }
        public TreeNode ConvertHelper(TreeNode root)
        {
            if (root == null || root.Right == null || root.Left == null)
                return root;

            TreeNode node = root;
            if (root.Left != null)
            {
                root.Left = ConvertHelper(root.Left);
                TreeNode tmp = root;
                root = root.Left;
                tmp.Left = null;

                node = root;
                while (node.Right != null)
                    node = node.Right;

                node.Right = tmp;
                node = node.Right;
            }

            node.Right = ConvertHelper(node.Right);
            return root;
        }

        private LinkedListNode ConvertToLinkedList(TreeNode root)
        {
            LinkedListNode head = null;
            LinkedListNode prev = null;
            while (root != null)
            {
                LinkedListNode node = new LinkedListNode(root.Value);
                if (head == null)
                {
                    prev = node;
                    head = node;
                }
                else
                {
                    prev.Next = node;
                    prev = node;
                }
                root = root.Right;
            }
            return head;
        }
    }
}
