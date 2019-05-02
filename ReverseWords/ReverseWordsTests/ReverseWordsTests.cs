using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReverseWords;

namespace ReverseWordsTests
{
    [TestClass]
    public class ReverseWordsTests
    {
        [TestMethod]
        public void WordReverserTests()
        {
            IWordReverser wordReverser = new WordReverser();
            RunTests(wordReverser);
        }

        private void RunTests(IWordReverser wordReverser)
        {
            NullTest(wordReverser);
            WordReverseTest(wordReverser);
        }

        private void NullTest(IWordReverser wordReverser)
        {
            string s = null;
            string result = wordReverser.ReverseWords(s);
            Assert.IsNull(result);
        }

        private void WordReverseTest(IWordReverser wordReverser)
        {
            string s = "My name is Chris";
            string expected = "Chris is name My";
            string result = wordReverser.ReverseWords(s);
            Assert.AreEqual(expected, result);
        }
    }
}
