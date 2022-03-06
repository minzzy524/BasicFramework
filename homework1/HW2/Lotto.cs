using System;
using System.Linq;  // .Contains 

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] num = new int[6];

            // 번호 
            for (int i = 0; i < num.Length; i++)
            {
                int a = rand.Next(1, 46);
                if (!num.Contains(a))
                    num[i] = a;
                else
                    i--;
            }

            // 버블정렬 
            for (int j = 0; j < num.Length - 1; j++)
            {
                for (int k = 1; k < num.Length - 1; k++)
                {
                    if (num[k] < num[k - 1])
                    {
                        // 스왑 
                        int temp = num[k];
                        num[k] = num[k - 1];
                        num[k - 1] = temp;
                    }
                }
            }

            Console.WriteLine("로또 번호");
            for (int m = 0; m < num.Length - 1; m++)
            {
                Console.Write(num[m] + " ");
            }
            Console.WriteLine();


        }
    }
}