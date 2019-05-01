using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTToLinkedList
{
    public class TreeNode
    {
        public TreeNode(int data)
        {
            Value = data;
        }
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}
