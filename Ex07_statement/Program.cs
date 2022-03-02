using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 제어문과 연산자 같이 연습
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i : {i}");
            }

            /* int i; 
             for (i = 0; i < 10; i++)
             {
                 Console.WriteLine($"i : {i}");
             }
             Console.WriteLine($"for 끝나고 i : {i}");*/  //이런 식으로는 잘 안 쓴다  i를 더 못 쓰니까

            /*            for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"i : {i}");
                        }*/

            // 이중 for문 구구단

            /*            for (int i = 2; i < 10; i++)
                        {
                            for (int j = 1; j < 10; j++)
                            {
                                if (i == j) break; // 현재 제어구문을 탈출하세요.
                                                   //Console.Write("{0} * {1} = {2}\t", i, j, i * j);
                                Console.Write("*");
                            }
                            Console.WriteLine(); // 엔터
                        }
                        for (int i = 2; i < 10; i++)
                        {
                            for (int j = 1; j < 10; j++)
                            {
                                if (i == j) continue; // skip하고 지나가라
                                Console.Write("{0} * {1} = {2}\t", i, j, i * j);

                            }
                            Console.WriteLine(); // 엔터

                        }
                        int result;
                        Console.Write("숫자값을 입력하세요");
                        result = int.Parse(Console.ReadLine()); // 입력받은 값을 정수값으로 변환


                        switch (result)
                        {
                            case 1:
                                Console.WriteLine(result);
                                break;
                            case 2:
                                Console.WriteLine(result);
                                break;
                            case 3:
                                Console.WriteLine(result);
                                break;
                            case 4:
                                Console.WriteLine(result);
                                break;
                            case 5:
                                Console.WriteLine(result);
                                break;
                            default:
                                Console.WriteLine("nothing");
                                break;

                        }*/

            // 1부터 100까지 합을 구해라
            // while(조건){}
            /*            int k = 1;
                        int ksum = 0; // 지역변수는 반드시 사용 전에 초기화
                        while (k <= 100)
                        {
                            ksum += k; // ksum = ksum + k
                            // 반드시 내부에서 증가감을 처리해줘야 함
                            k++; // 이래야 계속 k = 1 로 무한루프로 합 안 구한다.
                        }
                        Console.WriteLine("누적합 : {0}, i:{1}", ksum, k);


                        // 1부터 100까지 짝수 합 (내가 짠 거)
                        int m = 1;
                        int msum = 0;
                        while (m <= 100)
                        {
                            if (m % 2 == 0)
                            {
                                msum += m; // msum = msum + m
                            }
                            m++;
                        }
                        Console.WriteLine("짝수합 : {0}, m:{1} ", msum, m);*/

            // 1부터 100까지 홀수 합 (교수님이 짠 거)
            /*            int y = 1;
                        int ysum = 0;
                        while (y <= 100)
                        {
                            if(y % 2 == 0)
                            {
                                y++;
                                continue; // skip (아래 구문 스킵 후 위로 올라가서 실행)
                            }
                            ysum += y;
                            y++;

                        }
                        Console.WriteLine("홀수합 : {0}, y:{1}", ysum, y);


                        int even = 0; // 짝수
                        int odd = 0; // 홀수
                        for (int i = 1; i <= 100; i++)
                        {
                            if (i % 2 == 0)
                            {
                                even += i; // 짝수 조건식
                            }
                            else
                            { // 홀수 조건식 : i%2==1 or i%2!=0;
                                odd += i; 
                            }
                            Console.WriteLine("짝수 :{0}, 홀수 : {1}", even, odd);
                        }*/

            // Q. 지정된 계정 : admin , 암호 : 1234
            // 두 값을 콘솔에서 받아서 두 값이 모두 일치하는 경우 "성공" 출력
            // 하나라도 다르면 "넌 누구냐" 출력(if사용)

            // Console.ReadLine()
/*            Console.Write("사용자 ID : ");
            string id = Console.ReadLine();
            Console.Write("사용자 PWD : ");
            string pwd = Console.ReadLine();

            if (id == "admin" && pwd == "1234")
            {
                Console.WriteLine("성공");
            }
            else
            {
                Console.WriteLine("넌 누구냐");
            }
*/
            // if(i < 10 && j < 20 && k < 100 ...)
            // if(i < 10 || j < 20 || k < 100 ...)

            /*if ('A' != 65) // 같지 않니?
                // 어 같지 않아(true)
            {
                Console.WriteLine("True");
            }
            {
                // 어 같아
                Console.WriteLine("False");
            }*/

            // @@@ 중요 @@@ 연산자 중에서 암기해야 될 것 : 삼항연산자
            /*            int p2 = 10;
                        int k2 = -10;

                        int result2 = (p2 == k2) ?  p2 : k2;
                        Console.WriteLine($"result2:{0}");

                        // if 문으로
                        if (p2 == k2)
                        {

                        }
                        else
                        {

                        }*/

            int x1 = 3;
            int x2 = 5;

            // 비트 연산
            // 3 십진수 값을 이진수(0,1)
            // 128 64 32 16 8 4 2 1   (2의 배수)
            //              0 0 1 1   (십진수 3의 2진수 값)
            //              0 1 0 1   (십진수 5의 2진수 값)
            // AND 연산     0 0 0 1   3과5의 AND 연산 > 십진수 > 1
            // OR 연산      0 1 1 1   3과5의 OR  연산 > 십진수 > (1+2+4) > 7

            Console.WriteLine("x1 & x2" + (x1 & x2)); // 위에 어려운거 C#이 대신 해줄게
            Console.WriteLine(x1&x2); // 1
            Console.WriteLine(x1|x2); // 7



        }

    }
}
