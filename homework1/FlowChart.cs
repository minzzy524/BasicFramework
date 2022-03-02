/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class FlowChart
    {
        static void Main()
        {
            int UNIT = 10000;
            int NUM = 0;
            int SW = 0;


            Console.WriteLine("MONEY : ");
            int MONEY = int.Parse(Console.ReadLine());

            while (true)
            {
                NUM = (int)(MONEY / UNIT);
                Console.WriteLine($"UNIT : {UNIT}, NUM : {NUM}");

                if (UNIT > 1)
                {
                    MONEY -= UNIT * NUM;

                    if (SW == 0)
                    {
                        UNIT /= 2;
                        SW = 1;
                    }
                    else
                    {
                        UNIT /= 5;
                        SW = 0;
                    }
                }
                else
                {
                    break;
                }

            }

        }

    }
}
*/