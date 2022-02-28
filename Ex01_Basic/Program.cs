using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Basic // 논리적인 묶음의 단위 (클래스 간 충돌방지)
{
    // 클래스는 설계도이다. 클래스는  타입이다.
    // 클래스 이름을 붙이면 설계도, 객체 생성가능, 재사용성
    // 클래스 2가지 : 1. Main이 있는 클래스 (exe) 2. Main이 없는 클래스(dll)
    // 원칙적인 방법은 모든 클래스는 new라는 연산자를 통해서 메모리에 올라갈 수 있다.(원칙)
    // 원래는 Program p = new Program() 이런 식으로 해야되는데 이름이 Main이면 바로 실행하게 함.
    class Car // dll (Main 없으니까)
    {

    }

    class Test
    {
        public int data;
    }



    class Program // 클래스(설계도) 이름 // exe
    {// Method라고 부른다. (기능)  : static이면 독자적으로 메모리 확보할 수 있음
     // -> 이름이 Main이면 Stack 메모리에서 실행이 가능함
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            // 데이터 타입과 변수
            char c; // 선언 // 2byte (한글 한 자('가')는 2byte, 영문자/특수문자/공백 : 1byte) => dirthr : 한 문자를 2byte로 쓰자
            c = 'A';

            char d;
            d = '가'; // char는 한 문자를 저장하는 타입, 크기는 2byte(Unicode 체제)
            Console.WriteLine("c:{0}, d{1}", c, d);

            // 지역변수는 반드시 {초기화}를 통해서 사용한다.
            short s;
            s = 1000;
            Console.WriteLine();

            int i = 10000000;
            Console.WriteLine(i);

            // float f = 1.12; <- 이거 안된다 왜? 기본 타입이 float이 아닌 double 타입이니까 
            double f = 1.12f; // f는 접미사, 대문자 써도 됨 // 4byte 그릇에 담긴 값

            Console.WriteLine(f);

            double dd = 1.123456789;

            bool b = true; // 논리적인 구조 (제어구조 에서 논리 판단)

            // 값 타입 증명
            // aa 값 value type 증명
            int aa = 100;
            int bb = aa; // 할당 (값할당) -> 서로 영향 주지 않음
            bb = 200;
            Console.WriteLine("aa값은 {0}", aa);
            Console.WriteLine(aa.GetHashCode()); // 값이 들어있음

            // 참조 타입 증명
            Test t = new Test();
            Console.WriteLine(t.GetHashCode());
            t.data = 100;

            Test t2 = t; // 할당 (주소값) -> 서로 영향을 줌
            t2.data = 1111;
            Console.WriteLine("t 객체의 data 변수값은 {0}", t.data);
            Console.WriteLine(t == t2);
            Console.WriteLine("{0} - {1}", t.GetHashCode(), t2.GetHashCode());




        }
    }
}
