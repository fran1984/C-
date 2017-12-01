using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[] { 95, 69 };
            array[1] = new int[] { 80, 95, 76};
            array[2] = new int[] { 50, 95, 168,125,6 };

            int[] max = { 0, 0, 0 };
            for (int i = 0; i < 3; i++)
            {
                for (int j=0;j<array[i].Length;j++)
                {
                    if (array[i][j] > max[i])
                    {
                        max[i] = array[i][j];
                    }
                }
            }
            Console.WriteLine("\n95和69兩數中最大值為：" + max[0]);
            Console.WriteLine("\n80,95,76三數中最大值為：" + max[1]);
            Console.WriteLine("\n陣列 n [50, 95, 168,125, 6]中最大值為：" + max[2]);
            Console.Read();
        }
    }
}
