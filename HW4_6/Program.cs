using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n請輸入一正整數：");
            int num = int.Parse(Console.ReadLine());    //num = 20

            Console.Write("\n1~{0}間的質數有：",num);
            int i = (num - 1);  //i為所輸入之值以下每一個數 i=19~1
            
            do
            {
                int m = 1;  //進迴圈前reset m 值
                for (int j = i-1 ; j > 1 ; j--) //上述之數以下每一個數  j=18~1
                {
                    if (i % j == 0) { m = 0; }  //如果i可被某一個j整除(即i非質數)則m = 0;
                }
                if (m == 1){Console.Write(" {0} ",i);}  //m = 1 時代表i為質數。
                i--; 
            } while (i>0);
            Console.Read();
        }
    }
}