using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j = 0;
            string text = "";

            string[] name = new string[7] { "輸入錯誤","小明","小王","小呆","小華","王五","張三"};
            int[] score = new int[6] { 69, 74, 100, 32, 65, 23 };

            Console.Write("\n請輸入欲查詢的學生姓名：");
            text = (Console.ReadLine()).ToString();

            for (i = 0;i<name.Length;i++)
            {
                if (name[i] == text)
                {
                    j = i;
                }
            }

            if (j == 0)
            {
                Console.WriteLine("\n" + name[0] + "，請重新輸入！");
            }
            else
            {
                Console.WriteLine("\n找到了，{0}是第{1}位學生，他的成績是：{2}",name[j], j, score[j-1]);
            }
            Console.Read();
        }
    }
}
