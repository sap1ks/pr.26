using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[Size()];
            Massiv(mass);
            Output(mass);
            Console.ReadKey();
        }
        static int Size()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        static void Massiv(int[] mass)
        {

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"massiv[{i}]");
                mass[i] = int.Parse(Console.ReadLine());
            }

        }
        static void Output(int[] mass)
        {
            for (int i = 0; i <mass.Length; i++)
            {

                Console.WriteLine($"massiv[{i}]={mass[(i)]}");
            }
        }

    } }
        
    

