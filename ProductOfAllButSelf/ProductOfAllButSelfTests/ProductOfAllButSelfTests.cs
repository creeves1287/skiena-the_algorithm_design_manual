using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductOfAllButSelf;

namespace ProductOfAllButSelfTests
{
    [TestClass]
    public class ProductOfAllButSelfTests
    {
        [TestMethod]
        public void ProductOfAllButSelfFinderTests()
        {
            IProductOfAllButSelfFinder productOfAllButSelfFinder = new ProductOfAllButSelfFinder();
            RunTests(productOfAllButSelfFinder);
        }

        private void RunTests(IProductOfAllButSelfFinder productOfAllButSelfFinder)
        {
            NullTest(productOfAllButSelfFinder);
            ProductOfAllButSelfTest(productOfAllButSelfFinder);
        }

        private void NullTest(IProductOfAllButSelfFinder productOfAllButSelfFinder)
        {
            int[] a = null;
            int[] result = productOfAllButSelfFinder.FindProductOfAllButSelf(a);
            Assert.IsNull(result);
        }

        private void ProductOfAllButSelfTest(IProductOfAllButSelfFinder productOfAllButSelfFinder)
        {
            int[] a = new int[] { 3, 2, 5, 7, 6 };
            int[] expected = new int[] { 420, 630, 252, 180, 210 };
            int[] result = productOfAllButSelfFinder.FindProductOfAllButSelf(a);
            AssertResults(expected, result);
        }

        private void AssertResults(int[] expected, int[] result)
        {
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}
