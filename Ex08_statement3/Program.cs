using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_statement3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while
            // do ~ while (do를 무조건 한번은 실행하고 조건을 보러 간다.)
            // 의무(강제) 선행되어 실행

            /*int inputdata = 0;
            do // 먼저 실행하고 조건을 나중에 봐 (입력값 같은거 받을 때, 선행작업 있을 때 쓴다. ex. 키오스크)
            {
                Console.WriteLine("숫자를 입력해 주세요(0~9)");
                inputdata = int.Parse(Console.ReadLine());

            } while (inputdata >= 10); // 언제 탈출? 조건이 false일 때(inputdata => 9 , 8 , ...
                                       // (조건이 true면 do문을 계속 실행함.)
            Console.WriteLine("당신이 입력한 숫자는 : {0}", inputdata);*/


            // 간단한 피보나치 수열
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < 10; i++)
            {
                a = b;
                b = c;
                c = a + b;
                //Console.WriteLine($"{a} , {b} , {c}");
                Console.WriteLine($"c = {c}");
                Console.WriteLine();

            }

            // java 개발자가 C# 개발할 때 나오는 질문 한 가지
            // java == 비교가 주소값 비교, 문자열은 값이 중요 >> eqauls 통해서 값 비교
            // C#은 문자열 비교에서 "=="  써도 된다. << 카페 stirng과 string bulider 비교 한번 읽어봐

            string opr = "+";
            if(opr == "+")
            {
                Console.WriteLine("같은 문자열");
            } 



        }
    }
}
