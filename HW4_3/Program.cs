using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("\n請輸入五個整數：");
            Console.WriteLine();
            Console.WriteLine();
            int[] numbers = new int[5];

            for (i = 0; i < 5; i++)
            {
                Console.Write("請輸入第{0}個整數：",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("最小數：{0}", numbers[0]);
            Console.WriteLine("最大數：{0}", numbers[4]);
            Console.Read();
        }
    }
}
