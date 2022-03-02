using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int result;
            Console.Write("숫자값을 입력하세요");
            result = int.Parse(Console.ReadLine()); // 입력받은 값을 정수값으로 변환
            // C#에선 break 걸어줘라!

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

            }


            int data = 90;*/


            /*            switch (100)
                        {
                            case 100:Console.WriteLine(data);
                            case 90:Console.WriteLine(data);
                            case 80:Console.WriteLine(data);
                            default:Console.WriteLine("nothing");*/

            // Q 학점 계산시
            // 학점 A+ A- B+ B - ... F
            // 데이터 점수 : 94점

            // 판단기준 : 90 점 이상 >> A ....... 70점 이상 이면 C, 나머지는 F (판단 1번)
            // 95점 이상 >> A+ (판단 2번)
            // 아니면 A- (if 안에 if 써라)
            // 90(95 A+ 아니면 A-) .. 80 .. 70 나머지 F

            // 학점과 Grade 출력

            int score = 94;
            string grade = "";


            if (score >= 90)
            {
                grade = "A";
                if ((score >= 95) && (score <= 100))
                {
                    grade = "A+";

                }
                if ((score >= 91) && (score <= 94))
                {
                    grade = "A-";
                }

                // 교수님 방법 (삼항연산자 교재 149p)

                // grade = (score >= 95) ? (grade += "+") : (grade += "-"); // if 상황이 처리 가능
            }
            else if (score >= 80)
            {
                grade = "B";
                grade = (score >= 85) ? (grade += "+") : (grade += "-");
            }
            else if (score >= 70)
            {
                grade = "C";
                grade = (score >= 75) ? (grade += "+") : (grade += "-");
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine($"학점 : {score}, Grade : {grade}");


            //
            int m = 3;
            string r = "";
            switch (m)
            { // 조건식에 string 올 수 있다. char 올 수 있다.
                case 1:
                case 3:
                    Console.WriteLine(1);  //작업을 하니 다음 case 를 안되도 되잖아 .....
                    break;
                case 5:
                case 7:
                default:
                    r = "월 데이터가 아닙니다";
                    break;
            }
            Console.WriteLine(r);


            //사례 (switch case 가 break 를 가지지 않는 샘플)
            int month = 1;
            string res = ""; //빈 문자열로 초기화
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    res = "31";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    res = "30";
                    break;
                case 2:
                    res = "29";
                    break;
                default:
                    res = "월 데이터가 아닙니다";
                    break;
            }
            Console.WriteLine(res);

            // 메소드 체인 -> 함수로 나온 결과를 함수로 씌우고 그 함수의 결과를 또 함수로 넣고
            // 함수(). 함수(). 함수() Method Chain // 교재 113p
            // ConsoleKeyInfo() // 교재 118p

            // == 같다  C# "===" <- 없다/ JS에는 있다.

            // switch의 조건식에 stiring 올 수 있다. char 올 수 있다.

            // for(;;) 무한루프
            // while(true) 무한루프 -> 어떤 조건이 맞으면 break 걸어서 탈출 가능

            // @@@ 중요 @@@ foreach p.204
            // 우연히 java 언어와 JS 문법이 90% 같다. (분명히 다른 언어임.)

            // C#, JS : foreach(항목 in 항목들)
            // java : foreach(항목 : 항목들)  // java는 : 을 상속에 쓴다.

        }
    }
}
