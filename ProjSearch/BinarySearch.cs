using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjSearch
{
    public class BinarySearch
    {
        public  int BinarySearchIterative(int[] arr, int x)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (x < arr[mid])
                {
                    end = mid - 1;


                }
                else if (x > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
