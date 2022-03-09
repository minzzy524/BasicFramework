using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_String_class
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = "가";
            string b = "나";
            string c = a + b;
            Console.WriteLine($"c : {c}");

            string[] strarr = new string[] { "가", "나", "다", "라", "마" };

            foreach (string to in strarr)
            {
                Console.WriteLine($"to : {to}");
            }
            //주의사항 : string은 int, double 처럼 사용함(값타입처럼)

            string str = "가나다라마가나";

            int loc = str.IndexOf("다");
            Console.WriteLine(loc); 

            int lastloc = str.LastIndexOf("가");
            Console.WriteLine(lastloc);

            string strinsert = str.Insert(2, "하");
            Console.WriteLine(strinsert);

            string strremove = str.Remove(2, 2); // 2번째 인덱스부터 2개(근데 3개 지워짐)
            Console.WriteLine(strremove);

            string strreplace = str.Replace("가", "*");
            Console.WriteLine(strreplace);

            string strsubstring = str.Substring(2, 1); // (0,1) = 맨 처음 값 (start index, Length)
            Console.WriteLine(strsubstring);

            //문제  https://docs.microsoft.com/ko-kr/dotnet/api/system.string.substring?view=net-6.0
            string super = "슈퍼맨/팬티.노랑색/우하하-베트맨";
            string[] subs = super.Split('/', '.', '-');
            foreach (string i in subs)
            {
                Console.WriteLine(i);
            }

            char[] ch = new char[] { '/', '.', '-' };

            string[] strarray = super.Split(ch);
            foreach (string s in strarray)
            {
                Console.WriteLine(s);
            }

            int sum = 0;
            string[] numarr = { "1", "2", "3", "4", "5" };
            // 문제1) 배열에 있는 문자값들의 합을 sum 변수에 담아서 출력
            foreach (string i in numarr)
            {
                sum += Convert.ToInt32(i);

            }
            Console.WriteLine(sum);

            string Jumin = "123456-1234567";
            int sum_1 = 0;
            //문제 2) 주민번호의 합 (string은 char 배열이다.)
            // hint) jumin[i] >> return char >> 정수로 바꿀 수 없음 >> 문자열로 변경 >> 정수로 변경

            for (int i = 0; i < Jumin.Length; i++)
            {
                if (Jumin[i] == '-')
                {
                    continue; // 연산 안하겠다.
                }
                else
                {
                    sum_1 += int.Parse(Convert.ToString(Jumin[i]));
                }
            }
            Console.WriteLine(sum_1);


        }

        // 문자열의 누적 >> string으로 누적작업 하면 안된다. StringBuilder 이거 쓰자(데이터 많은 경우에)
        //StringBuilder sb =new StringBuilder();
        //sb.Append("가");
        //sb.Append("나");

    }
}