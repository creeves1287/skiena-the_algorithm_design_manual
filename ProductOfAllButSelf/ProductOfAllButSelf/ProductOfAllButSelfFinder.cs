using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfAllButSelf
{
    public class ProductOfAllButSelfFinder : IProductOfAllButSelfFinder
    {
        public int[] FindProductOfAllButSelf(int[] a)
        {
            if (a == null) return null;
            int[] result = new int[a.Length];
            FindProductOfAllButSelf(a, result, 0);
            return result;
        }

        private int FindProductOfAllButSelf(int[] a, int[] result, int i)
        {
            if (i == a.Length)
                return 1;

            if (i == 0)
                result[i] = 1;
            else
                result[i] = a[i - 1] * result[i - 1];

            int right = FindProductOfAllButSelf(a, result, i + 1);

            result[i] *= right;

            return right * a[i];
        }
    }
}
