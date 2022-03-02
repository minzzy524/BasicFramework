/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Stars
    {
        static void Main(string[] args)
        {   // 1번
            Console.WriteLine("1번 역삼각형 : \n");

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            // 2번
            Console.WriteLine();
            Console.WriteLine("2번 피라미드 : \n");


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }


            //3번
            Console.WriteLine();
            Console.WriteLine("3번 삼각형 : \n");


            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }


            // 4번 
            Console.WriteLine();
            Console.WriteLine("4번 마름모 : \n");
            

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                    Console.WriteLine();
            }

            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                    Console.Write(" ");
                for(int j = 7; j >= 2 * i - 1; j--)
                    Console.Write("*");
                Console.WriteLine();
            }


            *//*for (int m = 1; m < 5; m++)
            {
                for (int n = 4; n < 5; n++)
                    Console.Write(" ");
                for (int n = 1; n <=  ; n++)
                    Console.Write("*");
                Console.WriteLine();

            }*/


           /* for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();*//*

            }
    }
}

*/