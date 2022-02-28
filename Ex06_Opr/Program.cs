using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Opr
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // 연습 Main 함수 안에서 작업
            Console.WriteLine(100+100); // 숫자의 경우 "산술" 연산
            Console.WriteLine("100"+"100"); //100100 으로 나옴, 문자 일때는"결합" 연산
            Console.WriteLine("100"+100); // 결합이 이긴다. 숫자를 문자로 바꿔서 100100 출력

            int i = 10; // 지역변수 항상 초기화(습관적으로)
            int j;
            j = i++; // 후치 증가 (할당하고 증가)
            Console.WriteLine("i:{0}, j:{1}", i,j); // i = 11, j = 10

            j = ++i; // 전치 증가 (먼저 증가해서 할당)
            Console.WriteLine("i:{0}, j:{1}", i, j); // i = 12, j = 12

            // 혼자 있을때는 동일함
            int k = 100;
            k++;
            ++k;

            int sum = 0;
            int s2 = 100;
            // sum = sum + s2; // sum이 2번 나오면 싫어함
            sum += s2;

            int ysum;
            int y = 10;
            ysum = y++ + 10;
            Console.WriteLine($"{y},{ysum}"); // y = 11, ysum = 20

            int a = 10;
            int b = 20;
            if(a > 5 && b > 10) // true && true 일때 {} 코드 실행
            {
                Console.WriteLine("true");
            }

            /*
             
             SQL 언어(자연어)
             select(가져와) * from(~에서) emp where(~조건인 것들) sal > 1000 and job = "IT"

             select(가져와) * from(~에서) emp where(~조건인 것들) sal > 1000 or job = "IT"

             (0 1 조합)
                    and    or
             0 0     0     0
             0 1     0     1
             1 0     0     1
             1 1     1     1

             */


        }
    }
}
