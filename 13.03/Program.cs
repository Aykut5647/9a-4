using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //int[] arr=new int[n];

            //for(int i=0; i<arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());

            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        int swapInt = arr[j];
            //        int index = i;
            //        while (index > 0 && arr[index - 1] >= swapInt)
            //        {
            //            arr[index] = arr[index - 1];
            //            index--;
            //        }
            //        arr[index] = swapInt;

            //    }
            //    Console.WriteLine(string.Join(" ", arr));
            int n =int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i=0;i<n;i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < list.Count; i++)
            {
                {
                    Console.WriteLine("list[{0}]={1}", i, list[i]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(list);
                list.Remove(1);
                    Console.WriteLine(String.Join(", ", list));
            }
        }
        
    }
}
