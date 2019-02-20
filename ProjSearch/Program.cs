using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 45, 98, 2, 35, 9, 7 };
            int[] sorteddarr = arr.OrderBy(i => i).ToArray();

            BinarySearch binarySearch = new BinarySearch();
            var a = binarySearch.BinarySearchIterative(sorteddarr, 7);
            Console.WriteLine("Value is at position : " + a.ToString());
        }

        /// <summary>
        /// a = array
        /// x = what we are searching for
        /// p = first index
        /// q = mid point
        /// r = last index
        /// </summary>
       


       

    }
}
