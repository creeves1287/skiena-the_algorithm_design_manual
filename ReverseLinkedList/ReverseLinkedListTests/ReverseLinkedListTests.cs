using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseLinkedList;

namespace ReverseLinkedListTests
{
    [TestClass]
    public class ReverseLinkedListTests
    {
        [TestMethod]
        public void ReverseLinkedListWithStackTest()
        {
            ILinkedListReverser linkedListReverser = new LinkedListReverserWithStack();
            RunTests(linkedListReverser);
        }

        [TestMethod]
        public void RecursiveReverseLinkedListTest()
        {
            ILinkedListReverser linkedListReverser = new RecursiveLinkedListReverser();
            RunTests(linkedListReverser);
        }

        [TestMethod]
        public void ReverseLinkedListTest()
        {
            ILinkedListReverser linkedListReverser = new LinkedListReverser();
            RunTests(linkedListReverser);
        }

        private void RunTests(ILinkedListReverser linkedListReverser)
        {
            int length = 10;
            Node root = CreateLinkedList(length);
            Node result = linkedListReverser.ReverseList(root);
            for (int i = length; i > 0; i--)
            {
                Assert.AreEqual(i, result.Data);
                result = result.Next;
            }
        }

        private Node CreateLinkedList(int length)
        {
            Node root = new Node(1);
            Node node = root;
            for (int i = 2; i <= length; i++)
            {
                node.Next = new Node(i);
                node = node.Next;
            }
            return root;
        }
    }
}
