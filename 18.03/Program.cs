using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _18._03
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Kolko danni shte vivejdash? ");
            int n = int.Parse(Console.ReadLine());
            List<int> a = new List<int>();
            //vhod
            for (int i = 0; i < n; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));

            }
            //izhod
            for (int i = 0; i < a.Count + 1; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
            //izhod 2
            //for (int i = 0; i < a.Count; i++)
            //{
            //    if (a[i] < 1)
            //    {
            //       a.RemoveAt(i);
            //      i--;
            //    }
            //       Console.WriteLine("a[{0}]={1}", i, a[i]);
            //}
            //izhod 3
            for (int i = 0; i < a.Count + 1; i++)
            {
                a.Remove(2);
            }
            //Izhod 4
            for (int i = 0; i < a.Count + 1; i++)
            {
                a.Insert(2, 3);
            }
            //Izhod 5
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int b = a[j];
                        a[j] = a[j + 1];
                            a [j + 1] = b;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            //Izhod 6-cetni
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums.Add(int.Parse(Console.ReadLine()));
                }
            }
            //Izhod 7-otricatelni
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % -2 == 0)
                {
                    nums.Add(int.Parse(Console.ReadLine()));
                }
            }
            //Izhod 8-minimum

            //Izhod 9-ednakvi
            //List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int start=int.Parse(Console.ReadLine());
            //int length=int.Parse(Console.ReadLine());
            //for (int j = 0;j<list.Count; j++)
            //{
            //    for (int k = j;k<n-1-j; k++)
            //        if (start == length)
            //        {
            //            int bestStart=start++;
            //            int bestLength = length++;
            //        }
            //        else
            //        { 

            //        }
            //    for (int k = 0;k<n-1-j; k++)
            //}

        }
    }
}
