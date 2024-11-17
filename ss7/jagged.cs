using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss7
{
    internal class jagged
    {
        public static void Main()
        {
            ex1();
            Console.ReadLine();
        }
        public static void ex1()
        {
            int[][] a;
            Console.Write("Nhap so dong:  "); int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];
            nhapmangtudong(a, rows);
            inmang(a);
        }
        static void inmang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }

        }
        static void nhapmangtudong(int[][] a, int rows)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: "); int cols = int.Parse(Console.ReadLine());
                a[i]= new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    
                    //Console.Write($"a[{i}, {j} =");
                    a[i][j] = random.Next(100);
                }
            }
        }
    }
}
