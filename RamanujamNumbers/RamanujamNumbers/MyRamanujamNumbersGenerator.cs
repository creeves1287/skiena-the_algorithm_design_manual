using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamanujamNumbers
{
    public class MyRamanujamNumbersGenerator : IRamanujamNumbersGenerator
    {
        public List<int> GenerateRamanujamNumbers(int n)
        {
            int[] cubes = GenerateCubes(n);
            Dictionary<int, int> sumCounts = GenerateCubeSumCounts(cubes);
            List<int> result = GetRamanujamNumbers(sumCounts);
            return result;
        }

        private int[] GenerateCubes(int n)
        {
            int[] cubes = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                cubes[i] = (int)Math.Pow(i, 3);
            }
            return cubes;
        }

        private Dictionary<int, int> GenerateCubeSumCounts(int[] cubes)
        {
            Dictionary<int, int> sumCounts = new Dictionary<int, int>();
            for (int i = 0; i < cubes.Length - 1; i++)
            {
                for (int j = i + 1; j < cubes.Length; j++)
                {
                    int sum = cubes[i] + cubes[j];
                    if (sumCounts.ContainsKey(sum))
                    {
                        sumCounts[sum]++;
                    }
                    else
                    {
                        sumCounts.Add(sum, 1);
                    }
                }
            }
            return sumCounts;
        }

        private List<int> GetRamanujamNumbers(Dictionary<int, int> sumCounts)
        {
            List<int> ramanujamNumbers = new List<int>();
            foreach(KeyValuePair<int, int> sumCount in sumCounts)
            {
                if (sumCount.Key > 0 && sumCount.Value > 1)
                {
                    ramanujamNumbers.Add(sumCount.Key);
                }
            }
            return ramanujamNumbers;
        }
    }
}
