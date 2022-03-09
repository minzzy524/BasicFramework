using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex26_String_function_Quiz
{
    //주민번호 : 뒷번호 첫자리 : 1,3 남자 , 2,4 여자 라고 출력 ... 하는 문제

    //main 함수    주민번호 입력받고
    //앞:6자리     뒷:7자리
    //입력값 : 123456-1234567 

    //함수 3개를 static 
    //1. 자리수 체크 (기능)함수 (14 ok)  return true , false 
    //2. 뒷번호 첫번째 자리값 1~4까지의 값만 허용 기능함수  return true, false
    //3. 뒷번호 첫번째 자리값을 가지고 1,3 남자 , 2,4 여자 출력 기능함수  void  출력

    class Program
    {
        static void juminDisplay(string ssn)
        {
            bool first = juminFirstNumber(ssn);
            int first_num;

            if (first == true)
            {
                first_num = int.Parse(Convert.ToString(ssn.Substring(7, 1)));
                Console.WriteLine(((first_num == 1) || (first_num == 3)) ? "남자" : "여자");
            }
            else
            {
                Console.WriteLine("허용되지 않은 주민번호 입니다.");
            }
        }

        static bool juminFirstNumber(string str)
        {
            int first;
            bool check;
            check = juminCheck(str);

            first = (check == true) ? int.Parse(Convert.ToString(str.Substring(7, 1))) : 0;

            return ((first > 0) && (first <= 4) && (check == true)) ? true : false; ;
        }

        static bool juminCheck(string str)
        {
            return str.Length == 14 ? true : false;
        }

        static void Main(string[] args)
        {
            string jumin;
            Console.Write("주민번호를 입력하세요 : ");
            jumin = Console.ReadLine();
            juminDisplay(jumin); 

        }

    }
}
