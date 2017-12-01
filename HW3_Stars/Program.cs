using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 7; i++)
            {
                for (int j = 0; j <= i; j++){ Console.Write("*"); }
                Console.Write("\n");
            }
            Console.WriteLine();


            for (i = 0; i < 7; i++)
            {
                for (int j = 7; j > i; j--){ Console.Write("*"); }
                Console.Write("\n");
            }
            Console.WriteLine();


            for (i = 0; i < 7; i++)
            {
                for (int j = 6; j > i; j--){Console.Write(" ");}
                for (int k = 0; k <= i; k++){Console.Write("*");}
                Console.Write("\n");
            }
            Console.WriteLine();


            for (i = 0; i < 7; i++)
            {
                for (int j = 0; j < i; j++){Console.Write(" ");}
                for (int k = 7; k > i; k--){Console.Write("*");}
                Console.Write("\n");
            }
            Console.WriteLine();


            for (i = 0; i < 7; i++)
            {
                for (int j = 6; j > i; j--){Console.Write(" ");}
                for (int k = 0; k <= i; k++){Console.Write("*");}
                for (int m = 1; m <= i; m++){Console.Write("*");}
                Console.Write("\n");
            }
            Console.WriteLine();


            Console.Read();
        }
    }
}
