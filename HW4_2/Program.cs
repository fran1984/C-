using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] vote = new string [4][];
            vote[0] = new string[] { "胡歌", "650", "478", "111",""};
            vote[1] = new string[] {"劉詩詩", "14", "23", "58",""};
            vote[2] = new string[] { "金泰希", "500", "700", "65","" };
            vote[3] = new string[] { "金南佶", "124", "58", "666","" };

            double[] count = new double[4];

            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    count[i] += double.Parse(vote[i][j]);
                }
                sum += count[i];
            }

        
            Console.WriteLine("\n姓名\t第一區\t第二區\t第三區\t總票數");
            Console.WriteLine("======================================");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    vote[i][4] = count[i].ToString("###0");
                    Console.Write(vote[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < 4; i++)
            {
                //double rate = 0.23;
                double rate = (double)(count[i]) / (double)sum;
                //輸入字串格式不正確?
                Console.WriteLine(vote[i][0] + "\t得票率：" + rate.ToString("#0.##%"));
            }
            Console.Read();
        }
    }
}
