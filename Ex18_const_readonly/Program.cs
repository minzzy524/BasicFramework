using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_const_readonly
{
    class Test { // 둘 다 상수여서 바꿀 수 없음
        // const 상수 생성 시
        // 1. 객체간 공유자원 > 자동으로 static (공유자원)
        // 2. 의무적 (강제) 초기화

        public const int MAXVALUE = 10000;

        // raedonly 상수 생성 시
        // 1. 반드시 초기화 할 필요가 없다.
        // 2. 생성자에서 딱 한번 값을 할당 할 수 있다.(변경 불가)
        // 3. 객체가 가지는 상수 -> 객체마다 다른 상수를 갖게 하겠다는 의도 // 엘레베이터
        public readonly int readdata;

        public Test(int data)
        {
            readdata = data; // new 통한 생성 시  객체마다 다른 상수 값을 가지게 할 수 있다.
        }
    
    
    }




     class Program
    {
        static void Main(string[] args)
        {

            // const 
            Console.WriteLine(Test.MAXVALUE); // 모든 객체의 공유 자원이니까 Test.MAXVALUE 되네

            Test t = new Test(10);
            Console.WriteLine("t.readdata : {0}", t.readdata);
            Test t2 = new Test(20);
            Console.WriteLine("t2.readdata : {0}", t2.readdata);
            // t2.readdata = 100; // 할 수 없다 -> 한번 값이 할당되면 변경불가 읽기 전용이니까

        }
    }
}
