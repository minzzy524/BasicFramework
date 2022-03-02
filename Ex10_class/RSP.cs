/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{
     class RSP
    {
        static void Main(string[] args)
        {
            Boolean auto = true;
            Random rnd = new Random();


            while (auto)
            {
                int me = 1;
                string me_k = "가위";
                string other_k = "가위";
                int other = rnd.Next(1, 4);
                Console.WriteLine("1.가위 2.바위 3.보");
                Console.WriteLine("------------------");
                Console.Write("선택 : ");
                me = Convert.ToInt32(Console.ReadLine());
                if (me == 1)
                {
                    me_k = "가위";
                }
                else if (me == 2)
                {
                    me_k = "바위";
                }
                else if (me == 3)
                {
                    me_k = "보";
                }
                if (other == 1)
                {
                    other_k = "가위";
                }
                else if (other == 2)
                {
                    other_k = "바위";
                }
                else if (other == 3)
                {
                    other_k = "보";
                }
                Console.WriteLine($"나 : {me_k}, 상대 : {other_k}");

                switch (me)
                {
                    case 1:
                        if (other == 1) Console.WriteLine("비겼다");
                        else if (other == 2) Console.WriteLine("졌다");
                        else if (other == 3) Console.WriteLine("이겼다");
                        break;
                    case 2:
                        if (other == 1) Console.WriteLine("비겼다");
                        else if (other == 2) Console.WriteLine("졌다");
                        else if (other == 3) Console.WriteLine("이겼다");
                        break;
                    case 3:
                        if (other == 1) Console.WriteLine("비겼다");
                        else if (other == 2) Console.WriteLine("졌다");
                        else if (other == 3) Console.WriteLine("이겼다");
                        break;
                    case 4:
                        auto = false;
                        break;
                    default:
                        Console.WriteLine("다시 눌러주세요");
                        break;
                }
                Console.WriteLine("\n \n");

            }
        }
    }
}
*/