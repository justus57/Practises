using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 10, 30, 15 };
            int x = 30;
            int n = arr.Length;
            Console.WriteLine(x + "is present at index " + search(arr, n, x));
            Console.ReadLine();
            
        }
        static int search(int[] arr, int n,int x)
        {
            int i;
            for (i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
