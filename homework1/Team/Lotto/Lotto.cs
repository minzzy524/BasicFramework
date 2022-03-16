using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_Lotto_Main_
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] num = new int[6];
            Random rand = new Random();
            int temp;

            for (int i = 0; i < 6; i++)
            {
                int a = rand.Next(1, 46);
                num[i] = a;
                for (int j = 0; j < i; j++)
                {
                    if (i == 0) break;
                    num[i] = (num[i] == num[j]) ? i-- : num[i];
                }
            }
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.Write("정렬된 로또 번호 : ");
            foreach (int num1 in num)
            {
                Console.Write($"[{num1}]" + "    ");
            }
        }
    }
}