using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RamanujamNumbers;

namespace RamanujamNumberTests
{
    [TestClass]
    public class RamanujamNumberTests
    {
        [TestMethod]
        public void MyRamanujamNumberGeneratorTests()
        {
            IRamanujamNumbersGenerator ramanujamNumbersGenerator = new MyRamanujamNumbersGenerator();
            RunTests(ramanujamNumbersGenerator);
        }

        private void RunTests(IRamanujamNumbersGenerator ramanujamNumbersGenerator)
        {
            int n = 100000;
            List<int> result = ramanujamNumbersGenerator.GenerateRamanujamNumbers(n);
            for (int i = 0; i < result.Count; i++)
            {
                Trace.WriteLine(result[i].ToString());
            }
        }
    }
}
