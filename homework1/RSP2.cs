/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class RSP2
    {
        enum a { 가위, 바위, 보 };

        static void Main(string[] args)
        {
            Boolean auto = true;
            Random rnd = new Random();
            int me = 0;
            string me_k;
            string other_k;



            while (auto)
            {
                int other = rnd.Next(0, 3);
                Console.WriteLine("0.가위 1.바위 2.보 3.종료");
                Console.WriteLine("------------------");
                Console.Write("선택 : ");
                me = Convert.ToInt32(Console.ReadLine());
                me_k = Enum.GetName(typeof(a), me);
                other_k = Enum.GetName(typeof(a), other);

                Console.WriteLine($"나 : {me_k}, 상대 : {other_k}");

                if (me == other) Console.WriteLine("비겼습니다.");
                else
                {
                    switch (me)
                    {
                        case 0:
                            Console.WriteLine((other == 2) ? "이겼습니다." : "졌습니다.");
                            break;
                        case 1:
                            Console.WriteLine((other == 0) ? "이겼습니다." : "졌습니다.");
                            break;
                        case 2:
                            Console.WriteLine((other == 1) ? "이겼습니다." : "졌습니다.");
                            break;
                        case 3:
                            auto = false;
                            Console.WriteLine("종료되었습니다.");
                            break;
                        default:
                            Console.WriteLine("다시 선택해주세요");
                            break;
                    }
                }
                Console.WriteLine("\n \n");
            }
        }
    }
}*/