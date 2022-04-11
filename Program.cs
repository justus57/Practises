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
         

            node start = new node("d");
            start.next = new node("d");
            start.next.next = new node("e");
            printList(start);
            removeduplicates(start);
            Console.WriteLine("final result");
            printList(start);
            
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
        public static void removeduplicates(node head)
        {
            HashSet<string> hs = new HashSet<string>();
            node current = head;
            node prev = null;
            while(current != null)
            {
                string curval = current.val;
                if (hs.Contains(curval))
                {
                    prev.next = current.next;
                }
                else
                {
                    hs.Add(curval);
                    prev = current;
                }
                current = current.next;
            }
        }
        public class node
        {
            public string val;
            public node next;
            public node(string val)
            {
                this.val = val;
            }
        }

        //function to print nodes in a given linked list
        public static void printList(node head)
        {
            while(head != null)
            {
                Console.WriteLine(head.val + " ");
                head = head.next;
            }
        }

    }
}
