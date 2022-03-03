using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class ForFactorial
    {
        static void Main()
        {
/*            int fact = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"{i}! -> ");
                fact = 1;         //1로 초기화
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;  //1 * (1 * 2 * 3 * 4)
                }
                Console.WriteLine($"{fact,2}");
            }
*/

            int inputNum = 4;
            int resultNum = 1;

            for (int i = 1; i <= inputNum; i++)
            {
                resultNum *= i;
            }

            Console.WriteLine(resultNum);
            Console.WriteLine("------------");


            // 반대로
            resultNum = 1;
            for (int i = inputNum; i >= 1; i--)
            {
                resultNum *= i;
            }

            Console.WriteLine(resultNum);
        }
    }
}
