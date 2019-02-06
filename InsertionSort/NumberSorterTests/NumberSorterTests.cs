using System;
using InsertionSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberSorterTests
{
    [TestClass]
    public class NumberSorterTests
    {
        [TestMethod]
        public void InsertionSorterTests()
        {
            INumberSorter numberSorter = new InsertionSorter();
            RunTests(numberSorter);
        }

        private void RunTests(INumberSorter numberSorter)
        {
            NullTest(numberSorter);
            EmptyTest(numberSorter);
            SortTest(numberSorter);
        }

        private void NullTest(INumberSorter numberSorter)
        {
            int[] arr = null;
            try
            {
                numberSorter.Sort(arr);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {

            }
        }

        private void EmptyTest(INumberSorter numberSorter)
        {
            int[] arr = new int[0];
            numberSorter.Sort(arr);
        }

        private void SortTest(INumberSorter numberSorter)
        {
            int[] arr = new int[] { 3, 5, 6, 2, 1, 4, 8, 10, 7, 9 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numberSorter.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(expected[i], arr[i]);
            }
        }
    }
}
