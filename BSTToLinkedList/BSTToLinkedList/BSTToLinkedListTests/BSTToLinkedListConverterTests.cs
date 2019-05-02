using System;
using BSTToLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BSTToLinkedListTests
{
    [TestClass]
    public class BSTToLinkedListConverterTests
    {
        [TestMethod]
        public void BSTToLinkedListConverterWithStackTest()
        {
            IBSTToLinkedListConverter bSTToLinkedListConverter = new BSTToLinkedListConverterWithStack();
            RunTests(bSTToLinkedListConverter);
        }

        [TestMethod]
        public void BSTToLinkedListConverterFlattenTest()
        {
            IBSTToLinkedListConverter bSTToLinkedListConverter = new BSTToLinkedListConverterFlatten();
            RunTests(bSTToLinkedListConverter);
        }

        [TestMethod]
        public void BSTToLinkedListConverterFlattenRemakeTest()
        {
            IBSTToLinkedListConverter bSTToLinkedListConverter = new BSTToLinkedListConverterFlattenRemake();
            RunTests(bSTToLinkedListConverter);
        }

        private void RunTests(IBSTToLinkedListConverter bSTToLinkedListConverter)
        {
            NullTreeTest(bSTToLinkedListConverter);
            ConversionTest(bSTToLinkedListConverter);
        }

        private void NullTreeTest(IBSTToLinkedListConverter bSTToLinkedListConverter)
        {
            TreeNode bst = null;
            int[] expected = null;
            LinkedListNode result = bSTToLinkedListConverter.Convert(bst);
            Assert.AreEqual(expected, result);
        }

        private void ConversionTest(IBSTToLinkedListConverter bSTToLinkedListConverter)
        { 
            TreeNode bst = CreateBST();
            int[] expected = new int[] { 3, 6, 7, 10, 13, 16, 19 };
            LinkedListNode result = bSTToLinkedListConverter.Convert(bst);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result.Value);
                result = result.Next;
            }
        }

        private TreeNode CreateBST()
        {
            TreeNode root = new TreeNode(10)
            {
                Left = new TreeNode(6)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(7)
                },
                Right = new TreeNode(16)
                {
                    Left = new TreeNode(13),
                    Right = new TreeNode(19)
                }
            };
            return root;
        }
    }
}
