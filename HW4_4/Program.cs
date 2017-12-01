using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("\n請輸入十個整數：");
            Console.WriteLine();
            Console.WriteLine();
            int[] numbers = new int[10];

            for (i = 0; i < 10; i++)
            {
                Console.Write("請輸入第{0}個整數：", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            Console.WriteLine();
            Console.WriteLine("輸入整數遞增排序為：");
            for (i = 0; i < 10; i++)
            {
                Console.Write(numbers[i] + "， ");
            }
            Console.Read();
        }
    }
}
