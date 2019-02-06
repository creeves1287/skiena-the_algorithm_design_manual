using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class InsertionSorter : INumberSorter
    {
        public void Sort(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException("arr is null.");

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                        Swap(arr, j, j - 1);
                }
            }
        }

        private void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
