using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss7
{
    internal class vidujagged
    {
        public static void Main()
        {
            int[][] a;
            Console.Write("Nhap so dong:  "); int rows = int.Parse(Console.ReadLine());
            a= new int[rows][];
            nhapmangtudong(a, rows);
            inmang(a);
        }

        static void inmang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
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
                Console.Write($"Nhap so cot cho dong {i}: "); int cols=int.Parse(Console.ReadLine());
                for (int j = 0; j < cols; j++)
                {
                    a = new int [cols];
                    //Console.Write($"a[{i}, {j} =");
                    a[i][j] = random.Next(100);
                }
            } 
                
        }
        static void sortRow (int[][] a,int index)
        {
            int[] line = a[index];
            for (int i = 0;i < line.Length;i++)
            {
                for (int j= 0;j  <i;j ++)
                {
                    if (line)
                }
            }    
        }
    }
}
