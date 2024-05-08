using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] klas = new int[n];
            int[] nomer = new int[n];
            string[] ime = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Koy klas si? ");
                klas[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Koy nomer si? ");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Kak se kazvas? ");
                ime[i] = Console.ReadLine();
            }
            //"Sortirane po klas vizhodqsht red
            for (int i = 0; i < klas.Length - 1; i++)
            {
                for (int j = 0; j < klas.Length - 1; j++)
                {
                    if (klas[j] > klas[j + 1])
                    {
                        int swapInt = klas[j];
                        klas[j] = klas[j + 1];
                        klas[j + 1] = swapInt;
                    }
                }
            }
            for (int i = 0; i < klas.Length; i++)
            {
                Console.Write(klas[i] + " ");
            }
            //nizhodqsht
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i; j < n - 1 - i; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapInt1 = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapInt1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(nomer[i] + " ");
            }
            //sortirane po nomer,no ako 2 nomera sa ednakvi da sortira po klas
            for (int i = 0; i < nomer.Length - 1; i++)
            {
                for (int j = 0; j < nomer.Length - 1; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapInt2 = nomer[j];
                        nomer[j] = klas[j + 1];
                        nomer[j + 1] = swapInt2;
                    }
                    if (nomer[j] == nomer[j + 1])
                    {
                        int swapInt3 = nomer[j];
                        nomer[j] = klas[j + 1];
                        nomer[j + 1] = swapInt3;
                    }
                }
            }
            for (int i = 0; i < nomer.Length; i++)
            {
                Console.WriteLine(nomer[i] + " ");
            }
        }
    }
}