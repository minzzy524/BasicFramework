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

            int loc = str.IndexOf("가");
            Console.WriteLine(loc);

            int lastloc = str.LastIndexOf("가");
            Console.WriteLine(lastloc);

            string strinsert = str.Insert(2, "가");
            Console.WriteLine(strinsert);

            string strremove = str.Remove(2, 2);
            Console.WriteLine(strremove);

            string strreplace = str.Replace("가", "H");
            Console.WriteLine(strreplace);

            string strsubstring = str.Substring(2, 1);
            Console.WriteLine(strsubstring);

            //문제
            string super = "슈퍼맨/팬티.노랑색/우하하";
            string[] subs = super.Split('/', '.');
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
            //문제 2) 주민번호의 합
            for (int i = 0; i < Jumin.Length; i++)
            {
                if (Jumin[i] == '-')
                {
                    continue;
                }
                else
                {
                    sum_1 += int.Parse(Convert.ToString(Jumin[i]));
                }
            }
            Console.WriteLine(sum_1);


        }
    }
}