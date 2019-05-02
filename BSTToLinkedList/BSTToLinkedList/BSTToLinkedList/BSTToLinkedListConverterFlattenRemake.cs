using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTToLinkedList
{
    public class BSTToLinkedListConverterFlattenRemake : IBSTToLinkedListConverter
    {
        public LinkedListNode Convert(TreeNode root)
        {
            root = ConvertHelper(root);
            LinkedListNode head = ConvertToList(root);
            return head;
        }

        /*
         *           5
         *         /   \
         *        3     7
         *       / \   / \
         *      2   4 6   9
         */
        private TreeNode ConvertHelper(TreeNode root)
        {
            if (root == null || root.Left == null || root.Right == null)
                return root;

            TreeNode tmp = root;
            if (root.Left != null)
            {
                root.Left = ConvertHelper(root.Left);
                root = root.Left;

                TreeNode tmpRight = root;
                while (tmpRight.Right != null)
                    tmpRight = tmpRight.Right;

                tmpRight.Right = tmp;
                tmp.Left = null;
            }

            tmp.Right = ConvertHelper(tmp.Right);
            return root;
        }

        private LinkedListNode ConvertToList(TreeNode root)
        {
            LinkedListNode head = null;
            LinkedListNode prev = null;
            while (root != null)
            {
                LinkedListNode node = new LinkedListNode(root.Value);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    prev.Next = node;
                }
                prev = node;
                root = root.Right;
            }
            return head;
        }
    }
}
